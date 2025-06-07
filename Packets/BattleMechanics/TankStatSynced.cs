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
        public static int Id { get; } = -1672577397;
        public override string Description => "Server syncs tank movement stats with client";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
            FloatCodec.Instance,
            FloatCodec.Instance,
            FloatCodec.Instance,
            FloatCodec.Instance,
            ShortCodec.Instance,
        };
        public override string[] Attributes => new string[]
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
