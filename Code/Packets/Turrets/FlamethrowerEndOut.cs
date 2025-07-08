using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Firebird stops shooting
    /// </summary>
    public class FlamethrowerEndOut : AbstractPacket
    {
        public static int Id { get; } = -1300958299;
        public override string Description => "Firebird stops shooting";
        public override ICodec[] CodecObjects => new ICodec[]
        {
            IntCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "clientTime",
        };
    }
}
