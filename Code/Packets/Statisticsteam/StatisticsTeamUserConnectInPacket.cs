using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Statisticsteam;

public class StatisticsTeamUserConnectInPacket : Packet
{

	[Encode(0)]
	public string? UserId { get; set; }

	[Encode(1)]
	public UserInfo?[]? UserInfos { get; set; }

	[Encode(2)]
	public BattleTeam? Team { get; set; }

	public const int ID_CONST = 2040021062;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
