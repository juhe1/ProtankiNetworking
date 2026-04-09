# ProtankiNetworking

[![NuGet](https://img.shields.io/nuget/v/ProtankiNetworking.svg)](https://www.nuget.org/packages/ProtankiNetworking/)

**NuGet package:** [ProtankiNetworking on NuGet](https://www.nuget.org/packages/ProtankiNetworking/)

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
    public MyTankiServer(IPEndPoint localEndPoint)
        : base(localEndPoint)
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

    protected override Task OnClientConnectedAsync(TcpClient client)
    {
        return Task.CompletedTask;
    }

    protected override Task OnClientDisconnectedAsync(TcpClient client)
    {
        return Task.CompletedTask;
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
        Protection protection, 
        CancellationToken cancellationToken) 
        : base(client, protection, cancellationToken)
    {
    }

    protected override async Task OnRawPacketReceivedAsync(byte[] rawPacket)
    {
        Console.WriteLine($"Received raw packet of length {rawPacket.Length}");
    }

    protected override async Task OnPacketReceivedAsync(Packet packet)
    {
        Console.WriteLine($"Received packet of type {packet.GetType().Name}");
    }

    protected override async Task OnErrorAsync(Exception exception, string context)
    {
        Console.WriteLine($"Handler error in {context}: {exception.Message}");
    }

    protected override Task OnConnectedAsync()
    {
        return Task.CompletedTask;
    }

    protected override Task OnDisconnectedAsync()
    {
        return Task.CompletedTask;
    }

    protected override Task OnPacketUnwrapFailureAsync(Type packetType, int packetId, Exception exception)
    {
        Console.WriteLine($"Unwrap failed for {packetType.Name} ({packetId}): {exception.Message}");
        return Task.CompletedTask;
    }
}
```

### 3. Creating a Custom TCP Client

```csharp
public class MyTankiClient : TankiTcpClient
{
    public MyTankiClient(IPEndPoint serverEndPoint, Protection protection) 
        : base(serverEndPoint, protection)
    {
    }

    protected override async Task OnRawPacketReceivedAsync(byte[] rawPacket)
    {
        Console.WriteLine($"Received raw packet of length {rawPacket.Length}");
    }

    protected override async Task OnPacketReceivedAsync(Packet packet)
    {
        Console.WriteLine($"Received packet of type {packet.GetType().Name}");
    }

    protected override async Task OnErrorAsync(Exception exception, string context)
    {
        Console.WriteLine($"Client error in {context}: {exception.Message}");
    }

    protected override Task OnConnectedAsync()
    {
        return Task.CompletedTask;
    }

    protected override Task OnDisconnectedAsync()
    {
        return Task.CompletedTask;
    }

    protected override Task OnPacketUnwrapFailureAsync(Type packetType, int packetId, Exception exception)
    {
        Console.WriteLine($"Unwrap failed for {packetType.Name} ({packetId}): {exception.Message}");
        return Task.CompletedTask;
    }
}

// Usage:
var endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
var protection = new Protection(); // Configure protection as needed
var client = new MyTankiClient(endPoint, protection);
await client.ConnectAsync();
```

## Project Structure

- `Code/Codec/` - Data encoding/decoding system
- `Code/Networking/` - Network communication utilities
- `Code/Packets/` - Game packet definitions
- `Code/Security/` - Security and protection mechanisms

## Disclaimer

This library is for educational purposes only. Use of this library should comply with ProTanki's terms of service. (so you can't use it at all :D)
