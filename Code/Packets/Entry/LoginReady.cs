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
        public static int Id { get; } = -1277343167;
        public override string Description => "Server sends options for Login";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance,
            BoolCodec.Instance,
            IntCodec.Instance,
            IntCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "bgResourceID",
            "requireEmail",
            "maxPWLen",
            "minPWLen",
        };
    }
}
