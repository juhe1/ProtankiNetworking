using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Server syncs tank movement stats with client
    /// </summary>
    public class TankStatSynced : AbstractPacket
    {
        public static new int Id { get; } = -1672577397;
        public static new string Description { get; } = "Server syncs tank movement stats with client";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            FloatCodec.Instance,
            FloatCodec.Instance,
            FloatCodec.Instance,
            FloatCodec.Instance,
            ShortCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "username",
            "maxSpeed",
            "maxTurnSpeed",
            "maxTurretRotationSpeed",
            "acceleration",
            "specificationID",
        };
    }
}
