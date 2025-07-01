using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Smokey Shoot out
    /// </summary>
    public class SmokyShootWallOut : AbstractPacket
    {
        public static int Id { get; } = 1470597926;
        public override string Description => "Smokey Shoot out";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance,
            Vector3DCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "clientTime",
            "hitPoint",
        };
    }
}
