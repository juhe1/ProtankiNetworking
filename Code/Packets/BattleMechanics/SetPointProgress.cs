using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Packet for setting point progress (pointId, progress, progressSpeed).
    /// </summary>
    public class SetPointProgress : AbstractPacket
    {
        public static int Id { get; } = -2141998253;
        public override string Description => "Set point progress (pointId, progress, progressSpeed)";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance, // pointId
            FloatCodec.Instance, // progress
            FloatCodec.Instance, // progressSpeed
        };
        public override string[] Attributes => new string[]
        {
            "pointId",
            "progress",
            "progressSpeed",
        };
    }
} 