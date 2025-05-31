using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Entry
{
    /// <summary>
    /// Sets client language
    /// </summary>
    public class SetClientLang : AbstractPacket
    {
        public static new int Id { get; } = -1864333717;
        public static new string Description { get; } = "Sets client language";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "lang",
        };
    }
}
