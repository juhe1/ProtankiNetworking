using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Client moved passively
    /// </summary>
    public class TankMovementInfo : AbstractPacket
    {
        public static int Id { get; } = -1683279062;
        public override string Description => "Client moved passively";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance,
            ShortCodec.Instance,
            MoveCodec.Instance,
            FloatCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "clientTime",
            "specificationID",
            "movement",
            "turretDirection",
        };
    }
}
