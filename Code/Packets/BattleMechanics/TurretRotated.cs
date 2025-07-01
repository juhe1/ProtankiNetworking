using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Turret rotation data from server
    /// </summary>
    public class TurretRotated : AbstractPacket
    {
        public static int Id { get; } = 1927704181;
        public override string Description => "Turret rotation data from server";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
            TurretRotateCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "username",
            "turretRotation",
        };
    }
}
