using ProboTankiLibCS.Codec.Primitive;
using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Turrets
{
    /// <summary>
    /// Firebird attack
    /// </summary>
    public class FireDamagePacket : AbstractPacket
    {
        public static new int Id { get; } = 1395251766;
        public static new string Description { get; } = "Firebird attack";
        public static new string[] Attributes { get; } = new[] { "clientTime", "targets", "incarnationIDs", "targetBodyPositions", "targetHitPoints" };
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec), typeof(VectorStringCodec), typeof(VectorShortCodec), typeof(VectorVector3DCodec), typeof(VectorVector3DCodec) };
    }
} 