namespace ProtankiNetworking.Networking;

/// <summary>
///     Configuration for a SOCKS5 proxy server
/// </summary>
public record Socks5ProxyInfo
{
    /// <summary>
    ///     The proxy server IP address or hostname
    /// </summary>
    public required string Host { get; init; }

    /// <summary>
    ///     The proxy server port
    /// </summary>
    public required int Port { get; init; }

    /// <summary>
    ///     Optional SOCKS5 username for authentication
    /// </summary>
    public string? Username { get; init; }

    /// <summary>
    ///     Optional SOCKS5 password for authentication
    /// </summary>
    public string? Password { get; init; }

    /// <summary>
    ///     Whether authentication credentials are provided
    /// </summary>
    public bool HasCredentials => !string.IsNullOrEmpty(Username);
}
