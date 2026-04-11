using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battlecreate;

public class CheckBattleNameOutPacket : Packet
{

	[Encode(0)]
	public string? BattleName { get; set; }

	public const int ID_CONST = 566652736;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
