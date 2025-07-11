using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Shaft turret stopping manual targeting (shooter only).
/// </summary>
public class ShaftStopManualTargetingIn : AbstractPacket
{
    public const int ID_CONST = -1380283560;
    public override int Id => ID_CONST;
    public override string Description => "Shaft stop manual targeting (shooter)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance // shooter
    };

    public override string[] Attributes => new[]
    {
        "shooter"
    };
}