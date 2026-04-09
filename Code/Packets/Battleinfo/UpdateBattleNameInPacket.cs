using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battleinfo;

public class UpdateBattleNameInPacket : Packet
{

	[Encode(0)]
	public string? BattleId { get; set; }

	[Encode(1)]
	public string? BattleName { get; set; }

	public const int ID_CONST = 1561014187;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
