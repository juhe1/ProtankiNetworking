using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for firing a turret: time, barrel, shotId, shotDirection.
/// </summary>
public class TwinsFireOut : AbstractPacket
{
    public const int IdStatic = -159686980;
    public override int Id => IdStatic;
    public override string Description => "Fire command (time, barrel, shotId, shotDirection).";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance, // time
        ByteCodec.Instance, // barrel
        IntCodec.Instance, // shotId
        Vector3DCodec.Instance // shotDirection
    };

    public override string[] Attributes => new[]
    {
        "time",
        "barrel",
        "shotId",
        "shotDirection"
    };
}