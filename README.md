# ProboTankiLibCS

A C# library for ProTanki game communication. This project is a C# port of the [ProboTanki-Lib](https://github.com/Teinc3/ProboTanki-Lib) Python library.

## Features
- C# reimplementation of ProTanki client network commonication.
- Networking utilities for game communication
- Support for both synchronous and asynchronous operations

## Usage

Here's a basic example of how to use the library:

```csharp
using ProboTankiLibCS.Client;
using ProboTankiLibCS.Networking;
using ProboTankiLibCS.Processing;

// Create a processor instance
var processor = new YourProcessor();

// Create a socket instance
var socket = new TankiSocket(
    protection: new CProtection(),
    proxy: null,
    emergencyHalt: new ManualResetEvent(false),
    onPacketReceived: processor.ParsePackets,
    onSocketClose: (e, location, state) => Console.WriteLine($"Socket closed: {e.Message}")
);

// Connect to the game server
await socket.ConnectAsync("game.protanki.com", 443); // The address and port are not valid.
```

## Project Structure

- `Client/` - Client implementation classes
- `Codec/` - Data encoding/decoding system
- `Networking/` - Network communication utilities
- `Packets/` - Game packet definitions
- `Processing/` - Packet processing logic
- `Security/` - Security and protection mechanisms
- `Utils/` - Utility classes and helpers

## Acknowledgments

This project is based on the [ProboTanki-Lib](https://github.com/Teinc3/ProboTanki-Lib) Python library by [Teinc3](https://github.com/Teinc3).

## Disclaimer

This library is for educational purposes only. Use of this library should comply with ProTanki's terms of service. (so you can't use it at all :D)