using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Entry
{
    /// <summary>
    /// Loads the player's own account stats
    /// </summary>
    public class LoadAccountStats : AbstractPacket
    {
        public static int Id { get; } = 907073245;
        public override string Description => "Loads the player's own account stats";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance,
            IntCodec.Instance,
            IntCodec.Instance,
            BoolCodec.Instance,
            IntCodec.Instance,
            IntCodec.Instance,
            ByteCodec.Instance,
            FloatCodec.Instance,
            IntCodec.Instance,
            IntCodec.Instance,
            StringCodec.Instance,
            StringCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "crystals",
            "currentRankXP",
            "doubleCrystalLength",
            "hasDoubleCrystal",
            "nextRankXP",
            "ratingRank",
            "rank",
            "rating",
            "XP",
            "serverNumber",
            "username",
            "userProfileUrl",
        };
    }
}
