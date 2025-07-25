using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Player fires a hammer shot
/// </summary>
public class HammerShotOut : AbstractPacket
{
    public const int ID_CONST = -541655881;
    public override int Id => ID_CONST;
    public override string Description => "Player fires a hammer shot";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance,
        Vector3DCodec.Instance,
        new VectorCodec(TargetPositionCodec.Instance, false)
    };

    public override string[] Attributes => new[]
    {
        "clientTime",
        "direction",
        "shots"
    };
}