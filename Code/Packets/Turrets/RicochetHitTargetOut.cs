using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Packet for Ricochet hit target (time, target, shotId, targetPosition, impactPoints).
    /// </summary>
    public class RicochetHitTargetOut : AbstractPacket
    {
        public static int Id { get; } = 1229701582;
        public override string Description => "Ricochet hit target (time, target, shotId, targetPosition, impactPoints)";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance, // time (name_29)
            StringCodec.Instance, // target
            IntCodec.Instance, // shotId
            Vector3DCodec.Instance, // targetPosition (name_20)
            new VectorCodec(Vector3DCodec.Instance, true), // impactPoints (var_2664)
        };
        public override string[] Attributes => new string[]
        {
            "time",
            "target",
            "shotId",
            "targetPosition",
            "impactPoints",
        };
    }
} 