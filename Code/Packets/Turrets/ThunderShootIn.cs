using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Thunder shoot in (shooter only).
/// </summary>
public class ThunderShootIn : AbstractPacket
{
    public const int IdStatic = 958509220;
    public override int Id => IdStatic;
    public override string Description => "Thunder shoot in (shooter)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance // shooter
    };

    public override string[] Attributes => new[]
    {
        "shooter"
    };
}