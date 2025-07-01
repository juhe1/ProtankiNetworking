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
        public static int Id { get; } = -484994657;
        public override string Description => "Sends server details about a released railgun shot";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance,
            Vector3DCodec.Instance,
            VectorStringCodec.Instance,
            VectorVector3DCodec.Instance,
            VectorShortCodec.Instance,
            VectorVector3DCodec.Instance,
            VectorVector3DCodec.Instance,
        };
        public override string[] Attributes => new string[]
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
