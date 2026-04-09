using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battleitem;

public class ItemJoinedDmBattleInPacket : Packet
{

	[Encode(0)]
	public string? BattleId { get; set; }

	[Encode(1)]
	public string? UserId { get; set; }

	public const int ID_CONST = -2133657895;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
