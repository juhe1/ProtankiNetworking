using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Sends current turret rotation data to the server
/// </summary>
public class TurretRotation : AbstractPacket
{
    public static int Id { get; } = -114968993;
    public override string Description => "Sends current turret rotation data to the server";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance,
        TurretRotateCodec.Instance,
        ShortCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "clientTime",
        "turretRotation",
        "incarnationID"
    };
}