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
        public static int Id { get; } = -2030760866;
        public override string Description => "Sends server details about a released Shaft arcade shot";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance,
            Vector3DCodec.Instance,
            new VectorCodec(StringCodec.Instance, true),
            new VectorCodec(Vector3DCodec.Instance, true),
            new VectorCodec(ShortCodec.Instance, true),
            new VectorCodec(Vector3DCodec.Instance, true),
            new VectorCodec(Vector3DCodec.Instance, true),
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
