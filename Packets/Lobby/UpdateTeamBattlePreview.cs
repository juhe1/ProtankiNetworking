using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby
{
    /// <summary>
    /// Updates a team's score in the battle preview
    /// </summary>
    public class UpdateTeamBattlePreview : AbstractPacket
    {
        public static int Id { get; } = 1428217189;
        public override string Description => "Updates a team's score in the battle preview";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            StringCodec.Instance,
            IntCodec.Instance,
            IntCodec.Instance,
        };
        public override string[] Attributes => new string[]
        {
            "battleID",
            "team",
            "score",
        };
    }
}
