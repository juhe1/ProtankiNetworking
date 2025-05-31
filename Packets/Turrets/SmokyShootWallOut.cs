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
        public static new int Id { get; } = 1470597926;
        public static new string Description { get; } = "Smokey Shoot out";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            IntCodec.Instance,
            Vector3DCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "clientTime",
            "hitPoint",
        };
    }
}
