using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battleinfo;

public class JoinedTeamBattleInPacket : Packet
{

	[Encode(0)]
	public string? BattleId { get; set; }

	[Encode(1)]
	public BattleInfoUser? UserInfo { get; set; }

	[Encode(2)]
	public BattleTeam? Team { get; set; }

	public const int ID_CONST = 118447426;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
