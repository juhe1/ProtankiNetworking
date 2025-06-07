using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Player Ranked Up
    /// </summary>
    public class RankUp : AbstractPacket
    {
        public static int Id { get; } = 1262947513;
        public override string Description => "Player Ranked Up";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
            IntCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "username",
            "rank",
        };
    }
}
