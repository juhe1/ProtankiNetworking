using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for activating manual targeting in Shaft turret (shooter only).
/// </summary>
public class ShaftActivateManualTargetingIn : AbstractPacket
{
    public const int IdStatic = -1222085753;
    public override int Id => IdStatic;
    public override string Description => "Shaft activate manual targeting (shooter)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance // shooter
    };

    public override string[] Attributes => new[]
    {
        "shooter"
    };
}