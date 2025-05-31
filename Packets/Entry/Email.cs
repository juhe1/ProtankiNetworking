using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Entry
{
    /// <summary>
    /// email
    /// </summary>
    public class Email : AbstractPacket
    {
        public static new int Id { get; } = 613462801;
        public static new string Description { get; } = "email";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            BoolCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "email",
            "emailConfirmed",
        };
    }
}
