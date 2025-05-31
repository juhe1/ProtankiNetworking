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
        public static new int Id { get; } = 1927704181;
        public static new string Description { get; } = "Turret rotation data from server";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            TurretRotateCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "username",
            "turretRotation",
        };
    }
}
