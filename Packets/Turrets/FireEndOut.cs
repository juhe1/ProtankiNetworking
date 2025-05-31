using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Firebird stops shooting
    /// </summary>
    public class FireEndOut : AbstractPacket
    {
        public static new int Id { get; } = -1300958299;
        public static new string Description { get; } = "Firebird stops shooting";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            IntCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "clientTime",
        };
    }
}
