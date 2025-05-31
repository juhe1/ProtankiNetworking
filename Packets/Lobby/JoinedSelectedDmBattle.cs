using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// Sent when a player joins the currently-selected DM battle.
    /// </summary>
    public class JoinedSelectedDmBattle : AbstractPacket
    {
        public static new int Id { get; } = -911626491;
        public static new string Description { get; } = "Sent when a player joins the currently-selected DM battle.";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            BattleInfoUserCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "battleID",
            "userInfo",
        };
    }
}
