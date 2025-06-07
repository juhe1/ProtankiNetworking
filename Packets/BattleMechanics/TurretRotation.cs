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
        public static int Id { get; } = -114968993;
        public override string Description => "Sends current turret rotation data to the server";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance,
            TurretRotateCodec.Instance,
            ShortCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "clientTime",
            "turretRotation",
            "incarnationID",
        };
    }
}
