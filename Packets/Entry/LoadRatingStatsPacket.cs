using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Entry
{
    /// <summary>
    /// Player Rating stats
    /// </summary>
    public class LoadRatingStatsPacket : AbstractPacket
    {
        public static new int Id { get; } = -1128606444;
        public static new string Description { get; } = "Player Rating stats";
        public static new Type[] CodecTypes { get; } = new[] { typeof(FloatCodec), typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "rating", "place" };
    }
} 