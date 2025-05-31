using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo
{
    /// <summary>
    /// Battle fund
    /// </summary>
    public class BattleFund : AbstractPacket
    {
        public static new int Id { get; } = 1149211509;
        public static new string Description { get; } = "Battle fund";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            IntCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "fund",
        };
    }
}
