using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for setting point progress (pointId, progress, progressSpeed).
/// </summary>
public class SetPointProgress : AbstractPacket
{
    public static int IdStatic { get; } = -2141998253;
    public override int Id => IdStatic;
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