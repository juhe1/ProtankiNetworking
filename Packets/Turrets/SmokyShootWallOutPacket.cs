using ProboTankiLibCS.Codec.Primitive;
using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Turrets
{
    /// <summary>
    /// Smokey Shoot out
    /// </summary>
    public class SmokyShootWallOutPacket : AbstractPacket
    {
        public static new int Id { get; } = 1470597926;
        public static new string Description { get; } = "Smokey Shoot out";
        public static new string[] Attributes { get; } = new[] { "clientTime", "hitPoint" };
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec), typeof(Vector3DCodec) };
    }
} 