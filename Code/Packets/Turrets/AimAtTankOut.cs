using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for aiming at a tank (targetTank, localSpotPosition).
/// </summary>
public class AimAtTankOut : AbstractPacket
{
    public const int ID_CONST = -1517837003;
    public override int Id => ID_CONST;
    public override string Description => "Aim at tank out (targetTank, localSpotPosition)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance, // targetTank
        Vector3DCodec.Instance // localSpotPosition
    };

    public override string[] Attributes => new[]
    {
        "targetTank",
        "localSpotPosition"
    };
}