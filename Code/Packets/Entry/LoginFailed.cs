using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Entry
{
    /// <summary>
    /// Login failed
    /// </summary>
    public class LoginFailed : AbstractPacket
    {
        public static int Id { get; } = 103812952;
        public override string Description => "Login failed";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
        };
        public override string[] Attributes => new string[]
        {

        };
    }
}
