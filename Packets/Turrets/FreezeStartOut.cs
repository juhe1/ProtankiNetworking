using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// When we start using Freeze
    /// </summary>
    public class FreezeStartOut : AbstractPacket
    {
        public static new int Id { get; } = -75406982;
        public static new string Description { get; } = "When we start using Freeze";
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
