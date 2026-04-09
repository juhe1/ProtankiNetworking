using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battlelist;

public class SelectBattleInOutPacket : Packet
{

	[Encode(0)]
	public string? BattleId { get; set; }

	public const int ID_CONST = 2092412133;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
