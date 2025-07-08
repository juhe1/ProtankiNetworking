using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Packet for Shaft turret stopping manual targeting (shooter only).
    /// </summary>
    public class ShaftStopManualTargetingIn : AbstractPacket
    {
        public static int Id { get; } = -1380283560;
        public override string Description => "Shaft stop manual targeting (shooter)";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance, // shooter
        };
        public override string[] Attributes => new string[]
        {
            "shooter",
        };
    }
} 