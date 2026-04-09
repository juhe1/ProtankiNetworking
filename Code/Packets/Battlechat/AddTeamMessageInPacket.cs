using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battlechat;

public class AddTeamMessageInPacket : Packet
{

	[Encode(0)]
	public string? UserId { get; set; }

	[Encode(1)]
	public string? Message { get; set; }

	[Encode(2)]
	public BattleTeam? Team { get; set; }

	public const int ID_CONST = -449356094;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
