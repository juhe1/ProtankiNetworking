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
        public static new int Id { get; } = -1683279062;
        public static new string Description { get; } = "Client moved passively";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            IntCodec.Instance,
            ShortCodec.Instance,
            MoveCodec.Instance,
            FloatCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "clientTime",
            "specificationID",
            "movement",
            "turretDirection",
        };
    }
}
