using ProboTankiLibCS.Codec.Primitive;
using ProboTankiLibCS.Codec.Complex;

namespace ProboTankiLibCS.Packets.Turrets
{
    /// <summary>
    /// Our smoky shot hit a target
    /// </summary>
    public class SmokyShootTargetOutPacket : AbstractPacket
    {
        public static new int Id { get; } = 229267683;
        public static new string Description { get; } = "Our smoky shot hit a target";
        public static new string[] Attributes { get; } = new[] { "clientTime", "target", "incarnationID", "targetBodyPosition", "localHitPoint", "globalHitPoint" };
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec), typeof(StringCodec), typeof(ShortCodec), typeof(Vector3DCodec), typeof(Vector3DCodec), typeof(Vector3DCodec) };
    }
} 