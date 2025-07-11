using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Network;

/// <summary>
///     Pong Packet from client
/// </summary>
public class Pong : AbstractPacket
{
    public const int ID_CONST = 1484572481;
    public override int Id => ID_CONST;
    public override string Description => "Pong Packet from client";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}