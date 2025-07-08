using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;

namespace ProtankiNetworking.Networking;

/// <summary>
///     Handles TCP listener for accepting client connections and processing their packets
/// </summary>
public abstract class TankiTcpListener
{
    private readonly ConcurrentDictionary<TcpClient, TankiTcpClientHandler> _activeClients;
    private readonly TcpListener _listener;
    private Task? _acceptClientsTask;
    private CancellationTokenSource _cancellationTokenSource;

    /// <summary>
    ///     Creates a new instance of TankiTcpListener
    /// </summary>
    /// <param name="localEndPoint">The local endpoint to listen on</param>
    protected TankiTcpListener(IPEndPoint localEndPoint)
    {
        _listener = new TcpListener(localEndPoint);
        _cancellationTokenSource = new CancellationTokenSource();
        _activeClients = new ConcurrentDictionary<TcpClient, TankiTcpClientHandler>();
    }

    /// <summary>
    ///     Called when an error occurs
    /// </summary>
    /// <param name="exception">The exception that occurred</param>
    /// <param name="context">The context where the error occurred</param>
    protected abstract Task OnErrorAsync(Exception exception, string context);

    /// <summary>
    ///     Called when a client connects
    /// </summary>
    /// <param name="client">The client that connected</param>
    protected abstract Task OnClientConnectedAsync(TcpClient client);

    /// <summary>
    ///     Called when a client disconnects
    /// </summary>
    /// <param name="client">The client that disconnected</param>
    protected abstract Task OnClientDisconnectedAsync(TcpClient client);

    /// <summary>
    ///     Starts listening for client connections
    /// </summary>
    public void Start()
    {
        _listener.Start();
        _acceptClientsTask = AcceptClientsAsync();
    }

    /// <summary>
    ///     Stops listening for client connections
    /// </summary>
    public async Task StopAsync()
    {
        _cancellationTokenSource.Cancel();
        _listener.Stop();

        // Disconnect all active clients
        foreach (var client in _activeClients.Keys)
            try
            {
                client.Close();
                await OnClientDisconnectedAsync(client);
            }
            catch (Exception ex)
            {
                await OnErrorAsync(ex, "TankiTcpListener.StopAsync");
            }

        _activeClients.Clear();

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
    ///     Main loop for accepting client connections
    /// </summary>
    private async Task AcceptClientsAsync()
    {
        try
        {
            while (!_cancellationTokenSource.Token.IsCancellationRequested)
            {
                var client = await _listener.AcceptTcpClientAsync();
                var handler = CreateClientHandler(client, _cancellationTokenSource.Token);

                if (_activeClients.TryAdd(client, handler))
                {
                    await OnClientConnectedAsync(client);
                    _ = Task.Run(async () =>
                    {
                        try
                        {
                            await handler.StartAsync();
                        }
                        catch (Exception ex)
                        {
                            if (!(ex is OperationCanceledException))
                                await OnErrorAsync(ex, "TankiTcpListener.AcceptClients");
                        }
                        finally
                        {
                            _activeClients.TryRemove(client, out _);
                            try
                            {
                                client.Close();
                                await OnClientDisconnectedAsync(client);
                            }
                            catch
                            {
                                // Ignore errors during cleanup
                            }
                        }
                    });
                }
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
    ///     Creates a new TankiTcpClientHandler instance for a newly accepted client connection.
    ///     This method is called for each new client connection to instantiate a handler that will manage the client's
    ///     communication.
    /// </summary>
    /// <param name="client">The TcpClient instance for the new connection.</param>
    /// <param name="cancellationToken">The cancellation token to signal the handler to stop processing.</param>
    /// <returns>A new TankiTcpClientHandler instance.</returns>
    protected abstract TankiTcpClientHandler CreateClientHandler(
        TcpClient client,
        CancellationToken cancellationToken
    );
}
