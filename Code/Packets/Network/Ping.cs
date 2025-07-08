using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Network;

/// <summary>
///     Ping Packet from server
/// </summary>
public class Ping : AbstractPacket
{
    public static int Id { get; } = -555602629;
    public override string Description => "Ping Packet from server";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}