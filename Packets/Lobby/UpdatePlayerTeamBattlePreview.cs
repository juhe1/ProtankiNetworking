using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// Updates a player's score in a team battle preview
    /// </summary>
    public class UpdatePlayerTeamBattlePreview : AbstractPacket
    {
        public static new int Id { get; } = -375282889;
        public static new string Description { get; } = "Updates a player's score in a team battle preview";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            StringCodec.Instance,
            IntCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "battleID",
            "username",
            "score",
        };
    }
}
