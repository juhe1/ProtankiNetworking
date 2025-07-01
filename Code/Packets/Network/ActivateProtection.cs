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
        public static int Id { get; } = 2001736388;
        public override string Description => "Contains the keys required to activate packet encryption";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            new VectorCodec(ByteCodec.Instance, false),
        };
        public override string[] Attributes => new string[]
        {
            "keys",
        };
    }
}
