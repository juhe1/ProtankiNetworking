using ProboTankiLibCS.Codec.Complex;
using ProboTankiLibCS.Codec.Custom;
using ProboTankiLibCS.Codec.Primitive;

namespace ProboTankiLibCS.Packets.Turrets
{
    /// <summary>
    /// Sends server details about a released Shaft scope shot
    /// </summary>
    public class ShaftScopeOutPacket : AbstractPacket
    {
        public static new int Id { get; } = 1632423559;
        public static new string Description { get; } = "Sends server details about a released Shaft scope shot";
        public static new string[] Attributes { get; } = new[] { "clientTime", "staticHitPoint", "targets", "targetHitPoints", "incarnationIDs", "targetBodyPositions", "globalHitPoints" };
        public static new Type[] CodecTypes { get; } = new[] { typeof(IntCodec), typeof(Vector3DCodec), typeof(VectorStringCodec), typeof(VectorVector3DCodec), typeof(VectorShortCodec), typeof(VectorVector3DCodec), typeof(VectorVector3DCodec) };
    }
} 