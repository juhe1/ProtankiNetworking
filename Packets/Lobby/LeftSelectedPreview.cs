using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// A player has left the selected battle, from the preview screen
    /// </summary>
    public class LeftSelectedPreview : AbstractPacket
    {
        public static new int Id { get; } = 1924874982;
        public static new string Description { get; } = "A player has left the selected battle, from the preview screen";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            StringCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "battleID",
            "username",
        };
    }
}
