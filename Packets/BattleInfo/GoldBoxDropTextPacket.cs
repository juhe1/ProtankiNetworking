using ProboTankiLibCS.Codec.Primitive;
using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.BattleInfo
{
    /// <summary>
    /// Announces that a gold box will drop soon
    /// </summary>
    public class GoldBoxDropTextPacket : AbstractPacket
    {
        public static new int Id { get; } = -666893269;
        public static new string Description { get; } = "Announces that a gold box will drop soon";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "text", "soundID" };
    }
} 