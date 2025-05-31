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
        public static new int Id { get; } = 162656882;
        public static new string Description { get; } = "Information about a self destructed tank";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            IntCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "username",
            "respDelay",
        };
    }
}
