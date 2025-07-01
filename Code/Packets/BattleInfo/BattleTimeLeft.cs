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
        public static int Id { get; } = 732434644;
        public override string Description => "Battle time left in seconds";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "timeLimitInSec",
        };
    }
}
