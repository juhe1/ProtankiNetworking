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
        public static int Id { get; } = 696140460;
        public override string Description => "Updates the in-battle statistics of a player.";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            UserStatsCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "userStats",
        };
    }
}
