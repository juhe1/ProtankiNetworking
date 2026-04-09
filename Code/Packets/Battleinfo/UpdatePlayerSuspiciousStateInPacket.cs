using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battleinfo;

public class UpdatePlayerSuspiciousStateInPacket : Packet
{

	[Encode(0)]
	public string? BattleId { get; set; }

	[Encode(1)]
	public string? UserId { get; set; }

	[Encode(2)]
	public bool Suspicious { get; set; }

	public const int ID_CONST = -698399183;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
