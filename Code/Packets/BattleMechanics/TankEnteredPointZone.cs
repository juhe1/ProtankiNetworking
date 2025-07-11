using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for when a tank enters a point zone (pointId, tankId).
/// </summary>
public class TankEnteredPointZone : AbstractPacket
{
    public const int ID_CONST = -456245145;
    public override int Id => ID_CONST;
    public override string Description => "Tank entered point zone (pointId, tankId)";

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