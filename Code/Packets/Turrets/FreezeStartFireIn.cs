using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Freeze turret starting fire (shooter only).
/// </summary>
public class FreezeStartFireIn : AbstractPacket
{
    public static int IdStatic { get; } = -1171353580;
    public override int Id => IdStatic;
    public override string Description => "Freeze start fire (shooter)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance // shooter
    };

    public override string[] Attributes => new[]
    {
        "shooter"
    };
}