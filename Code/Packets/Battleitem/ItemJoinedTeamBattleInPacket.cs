using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battleitem;

public class ItemJoinedTeamBattleInPacket : Packet
{

	[Encode(0)]
	public string? BattleId { get; set; }

	[Encode(1)]
	public string? UserId { get; set; }

	[Encode(2)]
	public BattleTeam? Team { get; set; }

	public const int ID_CONST = -169305322;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
