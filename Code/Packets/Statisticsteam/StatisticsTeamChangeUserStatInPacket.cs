using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Statisticsteam;

public class StatisticsTeamChangeUserStatInPacket : Packet
{

	[Encode(0)]
	public UserStat? UserStats { get; set; }

	[Encode(1)]
	public BattleTeam? Team { get; set; }

	public const int ID_CONST = -497293992;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
