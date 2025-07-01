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
        public static int Id { get; } = 1227293080;
        public override string Description => "User requests to load their missions";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
        };
        public override string[] Attributes => new string[]
        {

        };
    }
}
