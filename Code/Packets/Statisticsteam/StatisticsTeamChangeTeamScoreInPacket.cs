using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Statisticsteam;

public class StatisticsTeamChangeTeamScoreInPacket : Packet
{

	[Encode(0)]
	public BattleTeam? Team { get; set; }

	[Encode(1)]
	public int Score { get; set; }

	public const int ID_CONST = 561771020;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
