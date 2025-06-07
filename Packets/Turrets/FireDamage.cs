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
        public static int Id { get; } = 1395251766;
        public override string Description => "Firebird attack";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance,
            VectorStringCodec.Instance,
            VectorShortCodec.Instance,
            VectorVector3DCodec.Instance,
            VectorVector3DCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "clientTime",
            "targets",
            "incarnationIDs",
            "targetBodyPositions",
            "targetHitPoints",
        };
    }
}
