using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using ProtankiNetworking.Packets;
using ProtankiNetworking.Security;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Networking
{
    /// <summary>
    /// Handles TCP listener for accepting client connections and processing their packets
    /// </summary>
    public abstract class TankiTcpListener
    {
        private readonly TcpListener _listener;
        private readonly CProtection _protection;
        private CancellationTokenSource _cancellationTokenSource;
        private Task _acceptClientsTask;

        /// <summary>
        /// Creates a new instance of TankiTcpListener
        /// </summary>
        /// <param name="localEndPoint">The local endpoint to listen on</param>
        /// <param name="protection">The protection instance for packet encryption/decryption</param>
        protected TankiTcpListener(
            IPEndPoint localEndPoint,
            CProtection protection)
        {
            _listener = new TcpListener(localEndPoint);
            _protection = protection;
            _cancellationTokenSource = new CancellationTokenSource();
        }
        
        /// <summary>
        /// Called when an error occurs
        /// </summary>
        /// <param name="exception">The exception that occurred</param>
        /// <param name="context">The context where the error occurred</param>
        protected abstract Task OnErrorAsync(Exception exception, string context);

        /// <summary>
        /// Starts listening for client connections
        /// </summary>
        public void Start()
        {
            _listener.Start();
            _acceptClientsTask = AcceptClientsAsync();
        }

        /// <summary>
        /// Stops listening for client connections
        /// </summary>
        public async Task StopAsync()
        {
            _cancellationTokenSource.Cancel();
            _listener.Stop();

            if (_acceptClientsTask != null)
            {
                try
                {
                    await _acceptClientsTask;
                }
                catch (OperationCanceledException)
                {
                    // Expected when cancelling
                }
            }
        }

        /// <summary>
        /// Main loop for accepting client connections
        /// </summary>
        private async Task AcceptClientsAsync()
        {
            try
            {
                while (!_cancellationTokenSource.Token.IsCancellationRequested)
                {
                    var client = await _listener.AcceptTcpClientAsync();
                    var handler = CreateClientHandler(client, _protection, _cancellationTokenSource.Token);
                    _ = handler.StartAsync();
                }
            }
            catch (OperationCanceledException)
            {
                // Expected when cancelling
            }
            catch (Exception e)
            {
                await OnErrorAsync(e, "TankiTcpListener.AcceptClients");
            }
        }

        /// <summary>
        /// Creates a new TankiTcpClientHandler instance for a newly accepted client connection.
        /// This method is called for each new client connection to instantiate a handler that will manage the client's communication.
        /// </summary>
        /// <param name="client">The TcpClient instance for the new connection.</param>
        /// <param name="protection">The protection instance for packet encryption/decryption.</param>
        /// <param name="cancellationToken">The cancellation token to signal the handler to stop processing.</param>
        /// <returns>A new TankiTcpClientHandler instance.</returns>
        protected abstract TankiTcpClientHandler CreateClientHandler(TcpClient client, CProtection protection, CancellationToken cancellationToken);
    }
} 