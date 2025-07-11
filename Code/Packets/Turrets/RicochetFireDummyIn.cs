using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Ricochet fire dummy event (shooter only).
/// </summary>
public class RicochetFireDummyIn : AbstractPacket
{
    public static int IdStatic { get; } = -1670466290;
    public override int Id => IdStatic;
    public override string Description => "Ricochet fire dummy event (shooter)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance // shooter
    };

    public override string[] Attributes => new[]
    {
        "shooter"
    };
}