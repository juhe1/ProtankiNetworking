using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battlelist;

public class RemoveBattleInPacket : Packet
{

	[Encode(0)]
	public string? BattleId { get; set; }

	public const int ID_CONST = -1848001147;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
