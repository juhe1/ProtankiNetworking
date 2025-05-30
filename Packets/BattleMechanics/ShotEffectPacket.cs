using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.BattleMechanics
{
    /// <summary>
    /// Shot effect packet
    /// </summary>
    public class ShotEffectPacket : AbstractPacket
    {
        public static new int Id { get; } = -1994318624;
        public static new string Description { get; } = "Shot effect packet";
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(IntCodec) };
        public static new string[] Attributes { get; } = new[] { "username", "effectId" };
    }
} 