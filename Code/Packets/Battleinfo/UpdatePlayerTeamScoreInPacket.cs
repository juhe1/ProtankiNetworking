using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battleinfo;

public class UpdatePlayerTeamScoreInPacket : Packet
{

	[Encode(0)]
	public string? BattleId { get; set; }

	[Encode(1)]
	public string? UserId { get; set; }

	[Encode(2)]
	public int Score { get; set; }

	public const int ID_CONST = -375282889;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
