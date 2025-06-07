using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo
{
    /// <summary>
    /// Update the score of a team within battle
    /// </summary>
    public class UpdateTeamBattleScore : AbstractPacket
    {
        public static int Id { get; } = 561771020;
        public override string Description => "Update the score of a team within battle";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
        };
        public override string[] Attributes => new string[]
        {

        };
    }
}
