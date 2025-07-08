using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Packet for activating manual targeting in Shaft turret (shooter only).
    /// </summary>
    public class ShaftActivateManualTargetingIn : AbstractPacket
    {
        public static int Id { get; } = -1222085753;
        public override string Description => "Shaft activate manual targeting (shooter)";
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