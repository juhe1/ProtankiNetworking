using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Packet for updating Shaft laser direction (shooterId, projectionOnVerticalAxis).
    /// </summary>
    public class ShaftLaserUpdateDirectionIn : AbstractPacket
    {
        public static int Id { get; } = -534192254;
        public override string Description => "Shaft laser update direction (shooterId, projectionOnVerticalAxis)";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance, // shooterId
            FloatCodec.Instance, // projectionOnVerticalAxis
        };
        public override string[] Attributes => new string[]
        {
            "shooterId",
            "projectionOnVerticalAxis",
        };
    }
} 