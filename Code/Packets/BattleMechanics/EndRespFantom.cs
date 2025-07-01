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
        public static int Id { get; } = 1178028365;
        public override string Description => "Client end the Fantom period to fully spawn";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
        };
        public override string[] Attributes => new string[]
        {

        };
    }
}
