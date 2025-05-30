using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Sent when a mine is placed or removed.
    /// </summary>
    public class MineLocationPacket : AbstractPacket
    {
        public static new int Id { get; } = 272183855;
        public static new string Description { get; } = "Sent when a mine is placed or removed.";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(FloatCodec), typeof(FloatCodec), typeof(FloatCodec), typeof(StringCodec) };
        public static new string[] Attributes { get; } = new[] { "mineId", "x", "y", "z", "userId" };
    }
} 