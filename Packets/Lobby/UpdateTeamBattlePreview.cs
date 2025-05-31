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
        public static new int Id { get; } = 1428217189;
        public static new string Description { get; } = "Updates a team's score in the battle preview";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
            StringCodec.Instance,
            IntCodec.Instance,
            IntCodec.Instance,
        };
        public static new string[] Attributes { get; } = new string[]
        {
            "battleID",
            "team",
            "score",
        };
    }
}
