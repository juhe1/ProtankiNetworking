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
        public static new int Id { get; } = 561771020;
        public static new string Description { get; } = "Update the score of a team within battle";
        public static new BaseCodec[] CodecObjects { get; } = new BaseCodec[]
        {
        };
        public static new string[] Attributes { get; } = new string[]
        {

        };
    }
}
