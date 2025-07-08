using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Packet for Shaft laser update direction out (projectionOnVerticalAxis).
    /// </summary>
    public class ShaftLaserUpdateDirectionOut : AbstractPacket
    {
        public static int Id { get; } = 1224288585;
        public override string Description => "Shaft laser update direction out (projectionOnVerticalAxis)";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            FloatCodec.Instance, // projectionOnVerticalAxis
        };
        public override string[] Attributes => new string[]
        {
            "projectionOnVerticalAxis",
        };
    }
} 