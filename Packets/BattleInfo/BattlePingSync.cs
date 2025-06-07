using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo
{
    /// <summary>
    /// Attempts to sync ping information with the server
    /// </summary>
    public class BattlePingSync : AbstractPacket
    {
        public static int Id { get; } = 2074243318;
        public override string Description => "Attempts to sync ping information with the server";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            DoubleIntCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "latencyInfo",
        };
    }
}
