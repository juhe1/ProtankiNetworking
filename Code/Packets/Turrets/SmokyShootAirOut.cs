using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Smokey Shoot at Air
    /// </summary>
    public class SmokyShootAirOut : AbstractPacket
    {
        public static int Id { get; } = 1478921140;
        public override string Description => "Smokey Shoot at Air";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            IntCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "clientTime",
        };
    }
}
