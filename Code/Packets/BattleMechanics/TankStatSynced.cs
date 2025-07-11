using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Server syncs tank movement stats with client
/// </summary>
public class TankStatSynced : AbstractPacket
{
    public const int ID_CONST = -1672577397;
    public override int Id => ID_CONST;
    public override string Description => "Server syncs tank movement stats with client";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        FloatCodec.Instance,
        FloatCodec.Instance,
        FloatCodec.Instance,
        FloatCodec.Instance,
        ShortCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "username",
        "maxSpeed",
        "maxTurnSpeed",
        "maxTurretRotationSpeed",
        "acceleration",
        "specificationID"
    };
}