using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Packet for sending Isida tick out event.
    /// </summary>
    public class IsidaTickOut : AbstractPacket
    {
        public static int Id { get; } = 244072998;
        public override string Description => "Send Isida tick out event";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance, // time
            ShortCodec.Instance, // targetIncarnation
            Vector3DCodec.Instance, // targetPosition
            Vector3DCodec.Instance, // localHitPoint
        };
        public override string[] Attributes => new string[]
        {
            "time",
            "targetIncarnation",
            "targetPosition",
            "localHitPoint",
        };
    }
} 