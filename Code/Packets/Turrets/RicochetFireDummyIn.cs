using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Ricochet fire dummy event (shooter only).
/// </summary>
public class RicochetFireDummyIn : AbstractPacket
{
    public const int ID_CONST = -1670466290;
    public override int Id => ID_CONST;
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