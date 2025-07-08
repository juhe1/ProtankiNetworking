using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Shaft laser aiming at a tank, with local spot position.
/// </summary>
public class ShaftLaserAimAtTankIn : AbstractPacket
{
    public static int Id { get; } = 11992250;
    public override string Description => "Shaft laser aim at tank (shooterId, targetTank, localSpotPosition)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance, // shooterId
        StringCodec.Instance, // targetTank
        Vector3DCodec.Instance // localSpotPosition
    };

    public override string[] Attributes => new[]
    {
        "shooterId",
        "targetTank",
        "localSpotPosition"
    };
}