using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for hit static command out (time, shotId, hitPointWorld).
/// </summary>
public class HitStaticCommandOut : AbstractPacket
{
    public const int ID_CONST = -482023661;
    public override int Id => ID_CONST;
    public override string Description => "Hit static command out (time, shotId, hitPointWorld)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance, // time (was name_29)
        IntCodec.Instance, // shotId
        Vector3DCodec.Instance // hitPointWorld (was var_3151)
    };

    public override string[] Attributes => new[]
    {
        "time",
        "shotId",
        "hitPointWorld"
    };
}