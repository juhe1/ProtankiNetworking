using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Client end the Fantom period to fully spawn
    /// </summary>
    public class EndRespFantom : AbstractPacket
    {
        public static new int Id { get; } = 1178028365;
        public static new string Description { get; } = "Client end the Fantom period to fully spawn";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
        };
        public static new string[] Attributes { get; } = new string[]
        {

        };
    }
}
