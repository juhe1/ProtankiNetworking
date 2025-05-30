namespace ProboTankiLibCS.Utils
{
    /// <summary>
    /// Configuration for reconnection behavior
    /// </summary>
    public class ReconnectionConfig
    {
        /// <summary>
        /// Maximum number of reconnections allowed before taking a break
        /// </summary>
        public int MaxReconnections { get; set; }

        /// <summary>
        /// Time interval in seconds to consider for reconnection counting
        /// </summary>
        public int ReconnectionInterval { get; set; }

        /// <summary>
        /// Break interval in minutes to wait after max reconnections
        /// </summary>
        public float BreakInterval { get; set; }

        /// <summary>
        /// Time in seconds to wait before instant reconnection
        /// </summary>
        public int InstantReconnectInterval { get; set; }

        /// <summary>
        /// Creates a new instance of ReconnectionConfig
        /// </summary>
        /// <param name="maxReconnections">Maximum number of reconnections allowed</param>
        /// <param name="reconnectionInterval">Time interval for reconnection counting</param>
        /// <param name="breakInterval">Break interval after max reconnections</param>
        /// <param name="instantReconnectInterval">Time to wait before instant reconnection</param>
        public ReconnectionConfig(
            int maxReconnections = 5,
            int reconnectionInterval = 300,
            float breakInterval = 5,
            int instantReconnectInterval = 5)
        {
            MaxReconnections = maxReconnections;
            ReconnectionInterval = reconnectionInterval;
            BreakInterval = breakInterval;
            InstantReconnectInterval = instantReconnectInterval;
        }
    }
} 