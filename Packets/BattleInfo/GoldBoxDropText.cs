using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo
{
    /// <summary>
    /// Announces that a gold box will drop soon
    /// </summary>
    public class GoldBoxDropText : AbstractPacket
    {
        public static new int Id { get; } = -666893269;
        public static new string Description { get; } = "Announces that a gold box will drop soon";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            IntCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "text",
            "soundID",
        };
    }
}
