using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Network;

/// <summary>
///     Pong Packet from client
/// </summary>
public class Pong : AbstractPacket
{
    public static int IdStatic { get; } = 1484572481;
    public override int Id => IdStatic;
    public override string Description => "Pong Packet from client";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}