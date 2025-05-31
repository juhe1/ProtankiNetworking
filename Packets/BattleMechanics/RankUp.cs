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
        public static new int Id { get; } = 1262947513;
        public static new string Description { get; } = "Player Ranked Up";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            IntCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "username",
            "rank",
        };
    }
}
