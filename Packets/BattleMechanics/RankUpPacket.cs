using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Player Ranked Up
    /// </summary>
    public class RankUpPacket : AbstractPacket
    {
        public static new int Id { get; } = 1262947513;
        public static new string Description { get; } = "Player Ranked Up";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "username", "rank" };
    }
} 