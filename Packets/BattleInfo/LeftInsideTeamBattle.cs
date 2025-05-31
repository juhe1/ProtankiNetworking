using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo
{
    /// <summary>
    /// A player has left a team battle, the observer being within the battle
    /// </summary>
    public class LeftInsideTeamBattle : AbstractPacket
    {
        public static new int Id { get; } = 1411656080;
        public static new string Description { get; } = "A player has left a team battle, the observer being within the battle";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "username",
        };
    }
}
