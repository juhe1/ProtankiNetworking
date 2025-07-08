using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Packet for hiding Shaft laser (shooterId only).
    /// </summary>
    public class ShaftLaserHideIn : AbstractPacket
    {
        public static int Id { get; } = -380595194;
        public override string Description => "Shaft laser hide (shooterId)";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance, // shooterId
        };
        public override string[] Attributes => new string[]
        {
            "shooterId",
        };
    }
} 