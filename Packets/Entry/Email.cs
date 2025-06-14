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
        public static int Id { get; } = 613462801;
        public override string Description => "email";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
            BoolCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "email",
            "emailConfirmed",
        };
    }
}
