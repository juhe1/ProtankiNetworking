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
        public static int Id { get; } = -666893269;
        public override string Description => "Announces that a gold box will drop soon";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
            IntCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "text",
            "soundID",
        };
    }
}
