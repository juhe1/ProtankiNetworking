using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo
{
    /// <summary>
    /// A new player has joined the team battle
    /// </summary>
    public class LoadNewPlayerTeam : AbstractPacket
    {
        public static new int Id { get; } = 2040021062;
        public static new string Description { get; } = "A new player has joined the team battle";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            new VectorCodec(BattleUserCodec.Instance, false),
            IntCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "username",
            "userinfos",
            "team",
        };
    }
}
