using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Firebird attack
    /// </summary>
    public class FireDamage : AbstractPacket
    {
        public static new int Id { get; } = 1395251766;
        public static new string Description { get; } = "Firebird attack";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            IntCodec.Instance,
            VectorStringCodec.Instance,
            VectorShortCodec.Instance,
            VectorVector3DCodec.Instance,
            VectorVector3DCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "clientTime",
            "targets",
            "incarnationIDs",
            "targetBodyPositions",
            "targetHitPoints",
        };
    }
}
