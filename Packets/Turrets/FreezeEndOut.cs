using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// When we stop using Freeze
    /// </summary>
    public class FreezeEndOut : AbstractPacket
    {
        public static new int Id { get; } = -1654947652;
        public static new string Description { get; } = "When we stop using Freeze";
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
