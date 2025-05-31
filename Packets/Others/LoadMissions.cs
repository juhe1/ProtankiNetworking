using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Others
{
    /// <summary>
    /// User requests to load their missions
    /// </summary>
    public class LoadMissions : AbstractPacket
    {
        public static new int Id { get; } = 1227293080;
        public static new string Description { get; } = "User requests to load their missions";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
        };
        public static new string[] Attributes { get; } = new string[]
        {

        };
    }
}
