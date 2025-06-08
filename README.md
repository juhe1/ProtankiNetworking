# ProtankiNetworking

A C# library for ProTanki game communication. This project is based on code from the [ProboTanki-Lib](https://github.com/Teinc3/ProboTanki-Lib) Python library, but it is not exact port.

## TCP Networking Components

The library provides three main components for TCP networking:

- `TankiTcpListener`: Base class for TCP server implementation that accepts client connections
- `TankiTcpClientHandler`: Base class for handling individual client connections to TankiTcpListener
- `TankiTcpClient`: Base class for TCP client implementation

## Usage Examples

### 1. Creating a Custom TCP Server

```csharp
public class MyTankiServer : TankiTcpListener
{
    public MyTankiServer(IPEndPoint localEndPoint, CProtection protection) 
        : base(localEndPoint, protection)
    {
    }

    protected override TankiTcpClientHandler CreateClientHandler(
        TcpClient client,
        CancellationToken cancellationToken)
    {
        return new MyClientHandler(client, new Protection(), cancellationToken);
    }

    protected override async Task OnErrorAsync(Exception exception, string context)
    {
        Console.WriteLine($"Server error in {context}: {exception.Message}");
    }
}

// Usage:
var endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
var server = new MyTankiServer(endPoint);
server.Start();
```

### 2. Creating a Custom Client Handler

```csharp
public class MyClientHandler : TankiTcpClientHandler
{
    public MyClientHandler(
        TcpClient client, 
        CProtection protection, 
        CancellationToken cancellationToken) 
        : base(client, protection, cancellationToken)
    {
    }

    protected override async Task OnRawPacketReceivedAsync(byte[] rawPacket)
    {
        Console.WriteLine($"Received raw packet of length {rawPacket.Length}");
    }

    protected override async Task OnPacketReceivedAsync(AbstractPacket packet)
    {
        Console.WriteLine($"Received packet of type {packet.GetType().Name}");
    }

    protected override async Task OnErrorAsync(Exception exception, string context)
    {
        Console.WriteLine($"Handler error in {context}: {exception.Message}");
    }
}
```

### 3. Creating a Custom TCP Client

```csharp
public class MyTankiClient : TankiTcpClient
{
    public MyTankiClient(IPEndPoint serverEndPoint, CProtection protection) 
        : base(serverEndPoint, protection)
    {
    }

    protected override async Task OnRawPacketReceivedAsync(byte[] rawPacket)
    {
        Console.WriteLine($"Received raw packet of length {rawPacket.Length}");
    }

    protected override async Task OnPacketReceivedAsync(AbstractPacket packet)
    {
        Console.WriteLine($"Received packet of type {packet.GetType().Name}");
    }

    protected override async Task OnErrorAsync(Exception exception, string context)
    {
        Console.WriteLine($"Client error in {context}: {exception.Message}");
    }
}

// Usage:
var endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
var protection = new CProtection(); // Configure protection as needed
var client = new MyTankiClient(endPoint, protection);
await client.ConnectAsync();
```

## Project Structure

- `Codec/` - Data encoding/decoding system
- `Networking/` - Network communication utilities
- `Packets/` - Game packet definitions
- `Security/` - Security and protection mechanisms

## Disclaimer

This library is for educational purposes only. Use of this library should comply with ProTanki's terms of service. (so you can't use it at all :D)