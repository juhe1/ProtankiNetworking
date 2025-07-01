using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Others
{
    /// <summary>
    /// Hides the loading screen or loader UI element
    /// </summary>
    public class HideLoader : AbstractPacket
    {
        public static int Id { get; } = -1282173466;
        public override string Description => "Hide the loader UI element";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
        };
        public override string[] Attributes => new string[]
        {
        };
    }
} 