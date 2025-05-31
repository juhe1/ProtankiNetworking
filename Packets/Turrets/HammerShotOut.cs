using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Player fires a hammer shot
    /// </summary>
    public class HammerShotOut : AbstractPacket
    {
        public static new int Id { get; } = -541655881;
        public static new string Description { get; } = "Player fires a hammer shot";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            IntCodec.Instance,
            Vector3DCodec.Instance,
            new VectorCodec(TargetPositionCodec.Instance, false),
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "clientTime",
            "direction",
            "shots",
        };
    }
}
