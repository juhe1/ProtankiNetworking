using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Sends current turret rotation data to the server
    /// </summary>
    public class TurretRotation : AbstractPacket
    {
        public static new int Id { get; } = -114968993;
        public static new string Description { get; } = "Sends current turret rotation data to the server";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            IntCodec.Instance,
            TurretRotateCodec.Instance,
            ShortCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "clientTime",
            "turretRotation",
            "incarnationID",
        };
    }
}
