using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo
{
    /// <summary>
    /// Updates the in-battle statistics of a player.
    /// </summary>
    public class UpdateBattlePlayerStatistics : AbstractPacket
    {
        public static new int Id { get; } = 696140460;
        public static new string Description { get; } = "Updates the in-battle statistics of a player.";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            UserStatsCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "userStats",
        };
    }
}
