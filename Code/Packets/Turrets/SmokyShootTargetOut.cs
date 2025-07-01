using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Our smoky shot hit a target
    /// </summary>
    public class SmokyShootTargetOut : AbstractPacket
    {
        public static int Id { get; } = 229267683;
        public override string Description => "Our smoky shot hit a target";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance,
            StringCodec.Instance,
            ShortCodec.Instance,
            Vector3DCodec.Instance,
            Vector3DCodec.Instance,
            Vector3DCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "clientTime",
            "target",
            "incarnationID",
            "targetBodyPosition",
            "localHitPoint",
            "globalHitPoint",
        };
    }
}
