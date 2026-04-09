using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battlecreate;

public class InitBattleSelectInPacket : Packet
{

	[Encode(0)]
	public string? BattlesJson { get; set; }

	public const int ID_CONST = -838186985;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
