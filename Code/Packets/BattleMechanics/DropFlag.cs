using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Packet for dropping a flag at a position for a team.
    /// </summary>
    public class DropFlag : AbstractPacket
    {
        public static int Id { get; } = 1925237062;
        public override string Description => "Drop flag at position for a team";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            Vector3DCodec.Instance, // position
            BattleTeamCodec.Instance, // flagTeam
        };
        public override string[] Attributes => new string[]
        {
            "position",
            "flagTeam",
        };
    }
} 