using ProboTankiLibCS.Codec.Primitive;
using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Factory;
using ProboTankiLibCS.Codec.Custom;

namespace ProboTankiLibCS.Packets.Turrets
{
    /// <summary>
    /// Player fires a hammer shot
    /// </summary>
    public class HammerShotOutPacket : AbstractPacket
    {
        public static new int Id { get; } = -541655881;
        public static new string Description { get; } = "Player fires a hammer shot";
        public static new string[] Attributes { get; } = new[] { "clientTime", "direction", "shots" };
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec), typeof(Vector3DCodec), typeof(VectorTargetPositionCodec) };
    }
} 