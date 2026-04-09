using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battleitem;

public class ItemUpdateBattleNameInPacket : Packet
{

	[Encode(0)]
	public string? BattleId { get; set; }

	[Encode(1)]
	public string? BattleName { get; set; }

	public const int ID_CONST = 2011860838;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
