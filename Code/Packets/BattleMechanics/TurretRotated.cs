using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Turret rotation data from server
/// </summary>
public class TurretRotated : AbstractPacket
{
    public const int ID_CONST = 1927704181;
    public override int Id => ID_CONST;
    public override string Description => "Turret rotation data from server";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        TurretRotateCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "username",
        "turretRotation"
    };
}