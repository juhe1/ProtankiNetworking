using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Network
{
    /// <summary>
    /// Contains the keys required to activate packet encryption
    /// </summary>
    public class ActivateProtection : AbstractPacket
    {
        public static new int Id { get; } = 2001736388;
        public static new string Description { get; } = "Contains the keys required to activate packet encryption";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            new VectorCodec(ByteCodec.Instance, false),
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "keys",
        };
    }
}
