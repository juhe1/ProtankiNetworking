using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Sends server details about a released railgun shot
/// </summary>
public class RailgunShotOut : AbstractPacket
{
    public const int ID_CONST = -484994657;
    public override int Id => ID_CONST;
    public override string Description => "Sends server details about a released railgun shot";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance,
        Vector3DCodec.Instance,
        new VectorCodec(StringCodec.Instance, true),
        new VectorCodec(Vector3DCodec.Instance, true),
        new VectorCodec(ShortCodec.Instance, true),
        new VectorCodec(Vector3DCodec.Instance, true),
        new VectorCodec(Vector3DCodec.Instance, true)
    };

    public override string[] Attributes => new[]
    {
        "clientTime",
        "staticHitPoint",
        "targets",
        "targetHitPoints",
        "incarnationIDs",
        "targetBodyPositions",
        "globalHitPoints"
    };
}