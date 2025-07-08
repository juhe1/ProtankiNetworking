using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Packet for Railgun fire out (time, staticHitPoint, targets, targetHitPoints, targetIncarnations, targetPositions, hitPointsWorld).
    /// </summary>
    public class RailgunFireOut : AbstractPacket
    {
        public static int Id { get; } = -484994657;
        public override string Description => "Railgun fire out (time, staticHitPoint, targets, targetHitPoints, targetIncarnations, targetPositions, hitPointsWorld)";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance, // time (name_29)
            Vector3DCodec.Instance, // staticHitPoint
            new VectorCodec(StringCodec.Instance, true), // targets
            new VectorCodec(Vector3DCodec.Instance, true), // targetHitPoints
            new VectorCodec(ShortCodec.Instance, true), // targetIncarnations (name_61)
            new VectorCodec(Vector3DCodec.Instance, true), // targetPositions (var_2788)
            new VectorCodec(Vector3DCodec.Instance, true), // hitPointsWorld (var_778)
        };
        public override string[] Attributes => new string[]
        {
            "time",
            "staticHitPoint",
            "targets",
            "targetHitPoints",
            "targetIncarnations",
            "targetPositions",
            "hitPointsWorld",
        };
    }
} 