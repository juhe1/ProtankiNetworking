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
        public static int Id { get; } = 118447426;
        public override string Description => "Sent when a player joins the currently-selected Team battle.";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
            BattleInfoUserCodec.Instance,
            IntCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "battleID",
            "userInfo",
            "team",
        };
    }
}
