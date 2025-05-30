using System.Net;
using ProboTankiLibCS.Networking;
using ProboTankiLibCS.Processing;
using ProboTankiLibCS.Security;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Client
{
    /// <summary>
    /// Base class for different types of Tanki instances
    /// </summary>
    public abstract class TankiInstance
    {
        /// <summary>
        /// Configuration for reconnection behavior
        /// </summary>
        public static ReconnectionConfig RECONNECTION_CONFIG { get; set; }

        /// <summary>
        /// The processor instance for handling packets
        /// </summary>
        protected AbstractProcessor Processor { get; }

        /// <summary>
        /// The socket instance for network communication
        /// </summary>
        protected TankiSocket TankiSocket { get; private set; }

        private readonly int _id;
        private readonly Dictionary<string, object> _credentials;
        private readonly List<DateTime> _reconnections;
        private readonly ManualResetEvent _emergencyHalt;
        private readonly Action _handleReconnect;
        private readonly Action<int> _onKillInstance;
        private readonly CProtection _protection;

        /// <summary>
        /// Creates a new instance of TankiInstance
        /// </summary>
        /// <param name="id">Instance identifier for debugging purposes</param>
        /// <param name="credentials">Instance credentials</param>
        /// <param name="handleReconnect">Callback for handling reconnection</param>
        /// <param name="onKillInstance">Callback for instance termination</param>
        /// <param name="reconnections">List of previous reconnection timestamps</param>
        protected TankiInstance(
            int id,
            Dictionary<string, object> credentials,
            Action handleReconnect,
            Action<int> onKillInstance,
            AbstractProcessor processor,
            List<DateTime> reconnections = null)
        {
            _id = id;
            _credentials = credentials;
            _reconnections = reconnections ?? new List<DateTime>();
            _emergencyHalt = new ManualResetEvent(false);
            _handleReconnect = handleReconnect;
            _onKillInstance = onKillInstance;
            _protection = new CProtection();
            Processor = processor;

            InstantiateSocket();
        }

        /// <summary>
        /// Instantiates the socket for network communication
        /// </summary>
        private void InstantiateSocket()
        {
            TankiSocket = new TankiSocket(
                _protection,
                _credentials.TryGetValue("proxy", out var proxy) ? (IPEndPoint)proxy : null,
                _emergencyHalt,
                Processor.ParsePackets,
                (e, location, state) => OnSocketClose(e, location, state, true, true, false)
            );
            Processor.SetSocketInstance(TankiSocket);
        }

        /// <summary>
        /// Handles socket closure and reconnection logic
        /// </summary>
        /// <param name="e">Exception that caused the closure</param>
        /// <param name="location">Location where the closure occurred</param>
        /// <param name="state">Current state when closure occurred</param>
        /// <param name="logError">Whether to log the error</param>
        /// <param name="addToReconnections">Whether to add to reconnection history</param>
        /// <param name="killInstance">Whether to kill the instance</param>
        private void OnSocketClose(
            Exception e,
            string location = null,
            string state = null,
            bool logError = true,
            bool addToReconnections = true,
            bool killInstance = false)
        {
            // Setup the exception
            e = new Exception("Socket closed", e);
            location ??= "[TankiInstance.OnSocketClose]";
            var reconnections = _reconnections.Select(r => $"<t:{((DateTimeOffset)r).ToUnixTimeSeconds()}:R>");
            state += $"\nID: {_id} | Credentials: {_credentials} | Previous reconnections: {string.Join(", ", reconnections)}";

            // Get the break interval before sending error message
            float breakInterval = addToReconnections ? CheckReconnection() : 0;

            // Add reconnection information to the error
            if (breakInterval > 0)
                e = new Exception($"Reconnecting in {breakInterval} minutes", e);
            else if (breakInterval == 0)
                e = new Exception("Reconnecting instantly", e);

            // Log error if requested
            if (logError)
                Console.WriteLine($"Error in {location}: {e.Message}\nState: {state}");

            // Cleanup the existing socket
            _emergencyHalt.Set();
            TankiSocket.CloseSocket();

            if (killInstance || breakInterval < 0)
            {
                // Kill instance, don't reconnect
                _onKillInstance(_id);
                return;
            }

            if (breakInterval == 0)
                breakInterval += RECONNECTION_CONFIG.InstantReconnectInterval / 60; // Add 5 seconds to prevent reconnecting too fast

            Thread.Sleep((int)(breakInterval * 60 * 1000));
            _handleReconnect();
        }

        /// <summary>
        /// Checks if the socket should be reconnected and calculates the break interval
        /// </summary>
        /// <returns>Number of minutes to wait before reconnecting. 0 means no wait. Negative value means no reconnect.</returns>
        private float CheckReconnection()
        {
            var currentTime = DateTime.Now;
            _reconnections.Add(currentTime);

            if (RECONNECTION_CONFIG.ReconnectionInterval > 0)
            {
                // Remove reconnections that are older than the reconnection interval
                _reconnections.RemoveAll(r => r < currentTime.AddSeconds(-RECONNECTION_CONFIG.ReconnectionInterval));
            }

            if (RECONNECTION_CONFIG.MaxReconnections <= 0)
                return 0;

            if (_reconnections.Count >= RECONNECTION_CONFIG.MaxReconnections)
            {
                float breakInterval = RECONNECTION_CONFIG.BreakInterval;
                return breakInterval >= 0 ? breakInterval : -1;
            }

            // No break interval, instant reconnect
            return 0;
        }
    }
} 