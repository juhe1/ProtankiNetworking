using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Packet for sending Isida set target out event.
    /// </summary>
    public class IsidaSetTargetOut : AbstractPacket
    {
        public static int Id { get; } = 381067984;
        public override string Description => "Send Isida set target out event";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance, // time
            StringCodec.Instance, // target
            ShortCodec.Instance, // targetIncarnation
            Vector3DCodec.Instance, // hitPoint
        };
        public override string[] Attributes => new string[]
        {
            "time",
            "target",
            "targetIncarnation",
            "hitPoint",
        };
    }
} 