using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for setting point progress (pointId, progress, progressSpeed).
/// </summary>
public class SetPointProgress : AbstractPacket
{
    public const int ID_CONST = -2141998253;
    public override int Id => ID_CONST;
    public override string Description => "Set point progress (pointId, progress, progressSpeed)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance, // pointId
        FloatCodec.Instance, // progress
        FloatCodec.Instance // progressSpeed
    };

    public override string[] Attributes => new[]
    {
        "pointId",
        "progress",
        "progressSpeed"
    };
}