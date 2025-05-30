using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Turrets
{
    /// <summary>
    /// Smokey Shoot in
    /// </summary>
    public class SmokyShotInPacket : AbstractPacket
    {
        public static new int Id { get; } = -1334002026;
        public static new string Description { get; } = "Smokey Shoot in";
        public static new string[] Attributes { get; } = new[] { "shooter", "target", "hitPoint", "weakeningCoeff", "isCritical" };
        public static new Type[] CodecTypes { get; } = new[] { typeof(StringCodec), typeof(StringCodec), typeof(Vector3DCodec), typeof(FloatCodec), typeof(BoolCodec) };
    }
} 