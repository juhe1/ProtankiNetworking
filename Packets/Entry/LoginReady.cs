using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Entry
{
    /// <summary>
    /// Server sends options for Login
    /// </summary>
    public class LoginReady : AbstractPacket
    {
        public static new int Id { get; } = -1277343167;
        public static new string Description { get; } = "Server sends options for Login";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            IntCodec.Instance,
            BoolCodec.Instance,
            IntCodec.Instance,
            IntCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "bgResourceID",
            "requireEmail",
            "maxPWLen",
            "minPWLen",
        };
    }
}
