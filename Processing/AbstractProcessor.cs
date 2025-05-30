using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ProboTankiLibCS.Communications;
using ProboTankiLibCS.Networking;
using ProboTankiLibCS.Packets;
using ProboTankiLibCS.Security;
using ProboTankiLibCS.Utils;

namespace ProboTankiLibCS.Processing
{
    /// <summary>
    /// Abstract base class for all tanki processors
    /// </summary>
    public abstract class AbstractProcessor
    {
        private readonly object _packetLock = new object();
        private readonly object _sendLock = new object();
        private readonly HashSet<System.Threading.Timer> _timers = new HashSet<System.Threading.Timer>();
        private readonly Dictionary<int, Func<Command, object>> _commandHandlers;
        private AbstractPacket _currentPacket;
        private long _lastClientTime;

        /// <summary>
        /// Gets or sets the current packet being processed
        /// </summary>
        protected AbstractPacket CurrentPacket
        {
            get
            {
                lock (_packetLock)
                    return _currentPacket;
            }
            set
            {
                lock (_packetLock)
                    _currentPacket = value;
            }
        }

        /// <summary>
        /// Gets the socket instance for network communication
        /// </summary>
        protected TankiSocket SocketInstance { get; private set; }

        /// <summary>
        /// Gets the protection instance for packet encryption/decryption
        /// </summary>
        protected CProtection Protection { get; }

        /// <summary>
        /// Gets the credentials for this processor
        /// </summary>
        protected Dictionary<string, object> Credentials { get; }

        /// <summary>
        /// Creates a new instance of AbstractProcessor
        /// </summary>
        /// <param name="socket">Socket instance for network communication</param>
        /// <param name="protection">Protection instance for packet encryption/decryption</param>
        /// <param name="credentials">Processor credentials</param>
        protected AbstractProcessor(
            TankiSocket socket,
            CProtection protection,
            Dictionary<string, object> credentials)
        {
            SocketInstance = socket;
            Protection = protection;
            Credentials = credentials;
            _commandHandlers = new Dictionary<int, Func<Command, object>>();
            RegisterCommandHandlers();
        }

        /// <summary>
        /// Registers command handlers for this processor
        /// </summary>
        protected abstract void RegisterCommandHandlers();

        /// <summary>
        /// Registers a handler for a specific command type
        /// </summary>
        /// <typeparam name="TCommand">The type of command to handle</typeparam>
        /// <param name="handler">The handler function</param>
        protected void RegisterHandler<TCommand>(Func<TCommand, object> handler) where TCommand : Command, new()
        {
            var command = new TCommand();
            _commandHandlers[command.Id] = cmd => handler((TCommand)cmd);
        }

        /// <summary>
        /// Handles a command by finding and executing its registered handler
        /// </summary>
        /// <param name="command">The command to handle</param>
        /// <returns>The result of the command handler</returns>
        protected object HandleCommand(Command command)
        {
            if (_commandHandlers.TryGetValue(command.Id, out var handler))
            {
                return handler(command);
            }
            throw new KeyNotFoundException($"No handler registered for command {command.Name} (ID: {command.Id})");
        }

        /// <summary>
        /// Processes packets specific to this processor
        /// </summary>
        protected abstract void ProcessPackets();

        /// <summary>
        /// Handles successful login
        /// </summary>
        protected abstract void OnLogin();

        /// <summary>
        /// Parses and processes received packets
        /// </summary>
        /// <param name="packet">The packet to process</param>
        public void ParsePackets(AbstractPacket packet)
        {
            CurrentPacket = packet;

            if (!ProcessUniversalPackets() && !ProcessEntryPackets())
                ProcessPackets();
        }

        /// <summary>
        /// Processes universal packets that yield the same result for all processors
        /// </summary>
        /// <returns>True if the packet was processed, false otherwise</returns>
        private bool ProcessUniversalPackets()
        {
            var packetObject = CurrentPacket.Object;

            if (ComparePacket("Ping"))
            {
                var pongPacket = PacketManager.CreatePacketByName("Pong");
                SendPacket(pongPacket);
            }
            else if (ComparePacket("Load_Resources"))
            {
                var loadedPacket = PacketManager.CreatePacketByName("Resources_Loaded");
                loadedPacket.Objects.Add(packetObject["callbackID"]); // Lazy deimplement
                SendPacket(loadedPacket);
            }
            else
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Processes entry packets that handle connection setup and authentication
        /// </summary>
        /// <returns>True if the packet was processed, false otherwise</returns>
        private bool ProcessEntryPackets()
        {
            var packetObject = CurrentPacket.Object;

            if (ComparePacket("Activate_Protection"))
            {
                Protection.Activate(((List<int>)packetObject["keys"]).ToArray());
            }
            else if (ComparePacket("Set_Captcha_Keys"))
            {
                var clientLangPacket = PacketManager.CreatePacketByName("Set_Client_Lang");
                clientLangPacket.Objects.Add("en");
                SendPacket(clientLangPacket);
            }
            else if (ComparePacket("Invite_Code_Status"))
            {
                if ((bool)packetObject["inviteEnabled"])
                    CloseSocket("Invite code required");
            }
            else if (ComparePacket("Login_Success"))
            {
                OnLogin();
            }
            else if (ComparePacket("Login_Failed"))
            {
                CloseSocket("Login Failed", addToReconnections: false, killInstance: true);
            }
            else if (ComparePacket("Banned"))
            {
                CloseSocket("Account Banned", addToReconnections: false, killInstance: true);
            }
            else
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Compares the current packet name with the given name
        /// </summary>
        /// <param name="name">The name to compare with</param>
        /// <returns>True if the names match, false otherwise</returns>
        protected bool ComparePacket(string name)
        {
            return PacketManager.GetPacketByName(name) == CurrentPacket.GetType();
        }

        /// <summary>
        /// Sends a packet through the socket
        /// </summary>
        /// <param name="packet">The packet to send</param>
        protected void SendPacket(AbstractPacket packet)
        {
            lock (_sendLock)
            {
                var buffer = packet.Wrap();
                SocketInstance.Send(buffer.ToArray());
            }
        }

        /// <summary>
        /// Closes the socket with a reason
        /// </summary>
        /// <param name="reason">The reason for closing</param>
        /// <param name="logError">Whether to log the error</param>
        /// <param name="addToReconnections">Whether to add to reconnections</param>
        /// <param name="killInstance">Whether to kill the instance</param>
        protected void CloseSocket(string reason, bool logError = true, bool addToReconnections = true, bool killInstance = false)
        {
            // Use the socket's callback to handle closure
            SocketInstance.OnSocketClose(
                new Exception(reason),
                GetType().Name,
                $"Current Packet: {CurrentPacket}",
                logError,
                addToReconnections,
                killInstance
            );
        }

        /// <summary>
        /// Creates a timer that executes a callback after a specified time
        /// </summary>
        /// <param name="deltaTime">Time in seconds before callback execution</param>
        /// <param name="callback">Callback to execute</param>
        /// <returns>The created timer</returns>
        protected System.Threading.Timer CreateTimer(float deltaTime, Action callback)
        {
            void WrappedCallback(object state)
            {
                try
                {
                    callback();
                }
                catch (Exception e)
                {
                    // Log error directly to console or file
                    Console.WriteLine($"Error in timer callback: {e.Message}");
                }
            }

            var timer = new System.Threading.Timer(WrappedCallback, null, (int)(deltaTime * 1000), Timeout.Infinite);
            lock (_timers)
                _timers.Add(timer);
            return timer;
        }

        /// <summary>
        /// Creates a timer that sends a packet after a specified time
        /// </summary>
        /// <param name="deltaTime">Time in seconds before sending the packet</param>
        /// <param name="packet">Packet to send</param>
        protected void CreatePacketTimer(int deltaTime, AbstractPacket packet)
        {
            CreateTimer(deltaTime, () => SendPacket(packet));
        }

        /// <summary>
        /// Kills all timer threads
        /// </summary>
        protected void KillTimerThreads()
        {
            lock (_timers)
            {
                foreach (var timer in _timers)
                {
                    timer.Dispose();
                }
                _timers.Clear();
            }
        }

        /// <summary>
        /// Sets the socket instance
        /// </summary>
        /// <param name="socket">The socket instance to set</param>
        public void SetSocketInstance(TankiSocket socket)
        {
            SocketInstance = socket;
        }
    }
} 