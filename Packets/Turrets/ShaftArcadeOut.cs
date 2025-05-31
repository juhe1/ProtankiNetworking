using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Sends server details about a released Shaft arcade shot
    /// </summary>
    public class ShaftArcadeOut : AbstractPacket
    {
        public static new int Id { get; } = -2030760866;
        public static new string Description { get; } = "Sends server details about a released Shaft arcade shot";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            IntCodec.Instance,
            Vector3DCodec.Instance,
            VectorStringCodec.Instance,
            VectorVector3DCodec.Instance,
            VectorShortCodec.Instance,
            VectorVector3DCodec.Instance,
            VectorVector3DCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "clientTime",
            "staticHitPoint",
            "targets",
            "targetHitPoints",
            "incarnationIDs",
            "targetBodyPositions",
            "globalHitPoints",
        };
    }
}
