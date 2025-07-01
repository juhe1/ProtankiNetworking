using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Load Bonus Box Resources
    /// </summary>
    public class UserSuppliesInfo : AbstractPacket
    {
        public static int Id { get; } = -137249251;
        public override string Description => "Load Bonus Box Resources";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "json",
        };
    }
}
