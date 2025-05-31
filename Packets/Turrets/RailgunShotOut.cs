using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Sends server details about a released railgun shot
    /// </summary>
    public class RailgunShotOut : AbstractPacket
    {
        public static new int Id { get; } = -484994657;
        public static new string Description { get; } = "Sends server details about a released railgun shot";
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
