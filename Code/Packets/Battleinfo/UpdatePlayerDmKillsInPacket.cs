using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battleinfo;

public class UpdatePlayerDmKillsInPacket : Packet
{

	[Encode(0)]
	public string? BattleId { get; set; }

	[Encode(1)]
	public string? UserId { get; set; }

	[Encode(2)]
	public int Kills { get; set; }

	public const int ID_CONST = -1263036614;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
