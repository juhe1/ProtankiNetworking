using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Information about a self destructed tank
    /// </summary>
    public class SelfDestructed : AbstractPacket
    {
        public static int Id { get; } = 162656882;
        public override string Description => "Information about a self destructed tank";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
            IntCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "username",
            "respDelay",
        };
    }
}
