using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for when a tank leaves a point zone (pointId, tankId).
/// </summary>
public class TankLeftPointZone : AbstractPacket
{
    public const int ID_CONST = -1410197917;
    public override int Id => ID_CONST;
    public override string Description => "Tank left point zone (pointId, tankId)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance, // pointId
        StringCodec.Instance // tankId
    };

    public override string[] Attributes => new[]
    {
        "pointId",
        "tankId"
    };
}