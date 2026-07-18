using System.Net;
using System.Net.Sockets;

namespace ProtankiNetworking.Networking;

/// <summary>
///     Helper class for establishing TCP connections through a SOCKS5 proxy
/// </summary>
internal static class Socks5ProxyClient
{
    /// <summary>
    ///     Connects to the specified target endpoint through a SOCKS5 proxy.
    ///     Returns the connected TcpClient, or throws on failure.
    /// </summary>
    public static async Task<TcpClient> ConnectThroughProxyAsync(
        Socks5ProxyInfo proxy,
        IPEndPoint target,
        CancellationToken cancellationToken = default
    )
    {
        // Step 1: Connect to the SOCKS5 proxy server
        var proxyClient = new TcpClient();
        await proxyClient.ConnectAsync(proxy.Host, proxy.Port, cancellationToken);
        var stream = proxyClient.GetStream();

        try
        {
            // Step 2: SOCKS5 handshake - negotiate authentication method
            byte[] authMethods;
            if (proxy.HasCredentials)
            {
                // No auth (0x00) + Username/Password (0x02)
                authMethods = [0x05, 0x02, 0x00, 0x02];
            }
            else
            {
                // Only no auth
                authMethods = [0x05, 0x01, 0x00];
            }

            await stream.WriteAsync(authMethods, cancellationToken);

            // Read server's chosen auth method
            var response = new byte[2];
            await stream.ReadExactlyAsync(response, 0, 2, cancellationToken);

            if (response[0] != 0x05)
                throw new InvalidOperationException($"SOCKS5: Invalid version: {response[0]}");

            if (response[1] == 0xFF)
                throw new InvalidOperationException("SOCKS5: No acceptable authentication method");

            // Step 3: Username/Password authentication if required
            if (response[1] == 0x02)
            {
                if (!proxy.HasCredentials)
                    throw new InvalidOperationException("SOCKS5: Server requires authentication but no credentials provided");

                var username = proxy.Username ?? "";
                var password = proxy.Password ?? "";
                var usernameBytes = System.Text.Encoding.UTF8.GetBytes(username);
                var passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);

                var authData = new byte[3 + usernameBytes.Length + passwordBytes.Length];
                authData[0] = 0x01; // Auth version
                authData[1] = (byte)usernameBytes.Length;
                Buffer.BlockCopy(usernameBytes, 0, authData, 2, usernameBytes.Length);
                authData[2 + usernameBytes.Length] = (byte)passwordBytes.Length;
                Buffer.BlockCopy(passwordBytes, 0, authData, 3 + usernameBytes.Length, passwordBytes.Length);

                await stream.WriteAsync(authData, cancellationToken);

                var authResponse = new byte[2];
                await stream.ReadExactlyAsync(authResponse, 0, 2, cancellationToken);

                if (authResponse[1] != 0x00)
                    throw new InvalidOperationException("SOCKS5: Authentication failed");
            }

            // Step 4: Send CONNECT request to target
            // Request format: VER(1) | CMD(1) | RSV(1) | ATYP(1) | DST.ADDR(var) | DST.PORT(2)
            // CMD = 0x01 (CONNECT)
            // ATYP = 0x01 (IPv4), 0x03 (Domain), 0x04 (IPv6)

            byte[] addressBytes;
            byte addressType;

            // Use the IP address directly
            var targetAddress = target.Address;
            if (targetAddress.AddressFamily == AddressFamily.InterNetwork)
            {
                addressType = 0x01; // IPv4
                addressBytes = targetAddress.GetAddressBytes();
            }
            else if (targetAddress.AddressFamily == AddressFamily.InterNetworkV6)
            {
                addressType = 0x04; // IPv6
                addressBytes = targetAddress.GetAddressBytes();
            }
            else
            {
                // Fallback to domain name resolution through proxy
                var hostName = target.Address.ToString();
                var hostBytes = System.Text.Encoding.UTF8.GetBytes(hostName);
                addressType = 0x03; // Domain name
                addressBytes = new byte[1 + hostBytes.Length];
                addressBytes[0] = (byte)hostBytes.Length;
                Buffer.BlockCopy(hostBytes, 0, addressBytes, 1, hostBytes.Length);
            }

            var portBytes = BitConverter.GetBytes(IPAddress.HostToNetworkOrder((short)target.Port));

            var connectRequest = new byte[4 + addressBytes.Length + 2];
            connectRequest[0] = 0x05; // VER
            connectRequest[1] = 0x01; // CMD = CONNECT
            connectRequest[2] = 0x00; // RSV
            connectRequest[3] = addressType;
            Buffer.BlockCopy(addressBytes, 0, connectRequest, 4, addressBytes.Length);
            connectRequest[4 + addressBytes.Length] = portBytes[0];
            connectRequest[4 + addressBytes.Length + 1] = portBytes[1];

            await stream.WriteAsync(connectRequest, cancellationToken);

            // Step 5: Read SOCKS5 response
            // Response format: VER(1) | REP(1) | RSV(1) | ATYP(1) | BND.ADDR(var) | BND.PORT(2)
            var connectResponse = new byte[4];
            await stream.ReadExactlyAsync(connectResponse, 0, 4, cancellationToken);

            if (connectResponse[0] != 0x05)
                throw new InvalidOperationException($"SOCKS5: Invalid response version: {connectResponse[0]}");

            if (connectResponse[1] != 0x00)
            {
                var errorMsg = connectResponse[1] switch
                {
                    0x01 => "General SOCKS server failure",
                    0x02 => "Connection not allowed by ruleset",
                    0x03 => "Network unreachable",
                    0x04 => "Host unreachable",
                    0x05 => "Connection refused",
                    0x06 => "TTL expired",
                    0x07 => "Command not supported",
                    0x08 => "Address type not supported",
                    _ => $"Unknown error code: {connectResponse[1]}"
                };
                throw new InvalidOperationException($"SOCKS5: {errorMsg}");
            }

            // Read the rest of the response (bind address and port)
            var addressTypeResp = connectResponse[3];
            int bindAddrLen = addressTypeResp switch
            {
                0x01 => 4,    // IPv4
                0x04 => 16,   // IPv6
                0x03 => 1 + (await ReadExactlyAsync(stream, 1, cancellationToken))[0], // Domain
                _ => throw new InvalidOperationException($"SOCKS5: Unknown address type in response: {addressTypeResp}")
            };

            if (bindAddrLen > 0)
            {
                var bindAddr = new byte[bindAddrLen];
                await stream.ReadExactlyAsync(bindAddr, 0, bindAddrLen, cancellationToken);
            }

            // Read bind port
            var bindPort = new byte[2];
            await stream.ReadExactlyAsync(bindPort, 0, 2, cancellationToken);

            // Connection established, return the client
            return proxyClient;
        }
        catch
        {
            proxyClient.Dispose();
            throw;
        }
    }

    private static async Task<byte[]> ReadExactlyAsync(
        NetworkStream stream,
        int count,
        CancellationToken cancellationToken
    )
    {
        var buffer = new byte[count];
        await stream.ReadExactlyAsync(buffer, 0, count, cancellationToken);
        return buffer;
    }
}
