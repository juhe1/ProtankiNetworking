using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Packet for when a team starts capturing a point (team: BattleTeam).
    /// </summary>
    public class PointCaptureStarted : AbstractPacket
    {
        public static int Id { get; } = -1346883037;
        public override string Description => "Point capture started (team)";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            BattleTeamCodec.Instance, // team
        };
        public override string[] Attributes => new string[]
        {
            "team",
        };
    }
} 