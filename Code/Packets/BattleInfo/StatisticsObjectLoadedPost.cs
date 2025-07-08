using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo
{
    /// <summary>
    /// Packet to indicate that the statistics object has been loaded (post event).
    /// </summary>
    public class StatisticsObjectLoadedPost : AbstractPacket
    {
        public static int Id { get; } = 1953272681;
        public override string Description => "Indicates that the statistics object has been loaded (post event)";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
        };
        public override string[] Attributes => new string[]
        {
        };
    }
} 