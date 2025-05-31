using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Initiates a shaft scope shot
    /// </summary>
    public class ShaftScopeInitOut : AbstractPacket
    {
        public static new int Id { get; } = -367760678;
        public static new string Description { get; } = "Initiates a shaft scope shot";
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
