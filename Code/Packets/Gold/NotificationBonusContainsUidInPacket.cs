using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Gold;

public class NotificationBonusContainsUidInPacket : Packet
{

	[Encode(0)]
	public string? Reason { get; set; }

	[Encode(1)]
	public string? Username { get; set; }

	[Encode(2)]
	public string? Uid { get; set; }

	public const int ID_CONST = 1382076950;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
