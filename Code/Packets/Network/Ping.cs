using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Network;

/// <summary>
///     Ping Packet from server
/// </summary>
public class Ping : AbstractPacket
{
    public static int IdStatic { get; } = -555602629;
    public override int Id => IdStatic;
    public override string Description => "Ping Packet from server";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}