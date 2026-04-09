using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battleitem;

public class ItemUpdateBattleSuspicionInPacket : Packet
{

	[Encode(0)]
	public string? BattleId { get; set; }

	[Encode(1)]
	public BattleSuspicionLevel? SuspicionLevel { get; set; }

	public const int ID_CONST = -751613832;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
