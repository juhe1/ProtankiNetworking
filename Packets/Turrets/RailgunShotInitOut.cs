using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Turrets
{
    /// <summary>
    /// Sends server details about a railgun shot that has just started to release
    /// </summary>
    public class RailgunShotInitOut : AbstractPacket
    {
        public static new int Id { get; } = -1759063234;
        public static new string Description { get; } = "Sends server details about a railgun shot that has just started to release";
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
