using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Turret Control Packet
    /// </summary>
    public class TurretControl : AbstractPacket
    {
        public static new int Id { get; } = -1749108178;
        public static new string Description { get; } = "Turret Control Packet";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            IntCodec.Instance,
            ShortCodec.Instance,
            ByteCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "clientTime",
            "specificationID",
            "control",
        };
    }
}
