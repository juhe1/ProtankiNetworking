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
        public static int Id { get; } = 1924874982;
        public override string Description => "A player has left the selected battle, from the preview screen";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
            StringCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "battleID",
            "username",
        };
    }
}
