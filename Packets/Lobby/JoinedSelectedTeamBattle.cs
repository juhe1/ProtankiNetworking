using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// Sent when a player joins the currently-selected Team battle.
    /// </summary>
    public class JoinedSelectedTeamBattle : AbstractPacket
    {
        public static new int Id { get; } = 118447426;
        public static new string Description { get; } = "Sent when a player joins the currently-selected Team battle.";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            BattleInfoUserCodec.Instance,
            IntCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "battleID",
            "userInfo",
            "team",
        };
    }
}
