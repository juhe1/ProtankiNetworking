using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battleitem;

public class ItemBattleMadePrivateInPacket : Packet
{

	[Encode(0)]
	public string? BattleId { get; set; }

	public const int ID_CONST = 1149131596;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
