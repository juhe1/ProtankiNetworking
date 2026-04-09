using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battleinfo;

public class RoundFinishedInPacket : Packet
{

	[Encode(0)]
	public string? BattleId { get; set; }

	public const int ID_CONST = 1534651002;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
