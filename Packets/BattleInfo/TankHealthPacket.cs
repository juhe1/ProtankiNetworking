using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.BattleInfo
{
    /// <summary>
    /// Updates the health of a tank
    /// </summary>
    public class TankHealthPacket : AbstractPacket
    {
        public static new int Id { get; } = -611961116;
        public static new string Description { get; } = "Updates the health of a tank";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(FloatCodec) };
        public static new string[] Attributes { get; } = new[] { "username", "health" };
    }
} 