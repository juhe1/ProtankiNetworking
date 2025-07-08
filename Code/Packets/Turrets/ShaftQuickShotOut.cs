using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Packet for Shaft quick shot out (time, staticHitPoint, targets, targetHitPoints, targetIncarnation, targetPosition, hitPointWorld).
    /// </summary>
    public class ShaftQuickShotOut : AbstractPacket
    {
        public static int Id { get; } = -2030760866;
        public override string Description => "Shaft quick shot out (time, staticHitPoint, targets, targetHitPoints, targetIncarnation, targetPosition, hitPointWorld)";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance, // time
            Vector3DCodec.Instance, // staticHitPoint
            new VectorCodec(StringCodec.Instance, true), // targets
            new VectorCodec(Vector3DCodec.Instance, true), // targetHitPoints
            new VectorCodec(ShortCodec.Instance, true), // targetIncarnation (name_61)
            new VectorCodec(Vector3DCodec.Instance, true), // targetPosition (var_2788)
            new VectorCodec(Vector3DCodec.Instance, true), // hitPointWorld (var_778)
        };
        public override string[] Attributes => new string[]
        {
            "time",
            "staticHitPoint",
            "targets",
            "targetHitPoints",
            "targetIncarnation",
            "targetPosition",
            "hitPointWorld",
        };
    }
} 