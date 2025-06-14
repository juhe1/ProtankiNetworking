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
        public static int Id { get; } = -375282889;
        public override string Description => "Updates a player's score in a team battle preview";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
            StringCodec.Instance,
            IntCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "battleID",
            "username",
            "score",
        };
    }
}
