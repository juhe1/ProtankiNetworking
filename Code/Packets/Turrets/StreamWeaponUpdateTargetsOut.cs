using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Packet for stream weapon update targets (time, direction, targets).
    /// </summary>
    public class StreamWeaponUpdateTargetsOut : AbstractPacket
    {
        public static int Id { get; } = -1889502569;
        public override string Description => "Stream weapon update targets (time, direction, targets)";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance, // time
            Vector3DCodec.Instance, // direction
            new VectorCodec(TargetPositionCodec.Instance, false), // targets
        };
        public override string[] Attributes => new string[]
        {
            "time",
            "direction",
            "targets",
        };
    }
}