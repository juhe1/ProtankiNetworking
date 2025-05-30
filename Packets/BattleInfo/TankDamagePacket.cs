using System;
using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.BattleInfo
{
    /// <summary>
    /// Damage dealt to a tank
    /// </summary>
    public class TankDamagePacket : AbstractPacket
    {
        public static new int Id { get; } = -1165230470;
        public static new string Description { get; } = "Damage dealt to a tank";
        public static new Type[] CodecTypes { get; } = new[] { typeof(VectorTankDamageCodec) };
        public static new string[] Attributes { get; } = new[] { "damages" };
    }
} 