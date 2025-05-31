using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo
{
    /// <summary>
    /// Battle time left in seconds
    /// </summary>
    public class BattleTimeLeft : AbstractPacket
    {
        public static new int Id { get; } = 732434644;
        public static new string Description { get; } = "Battle time left in seconds";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            IntCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "timeLimitInSec",
        };
    }
}
