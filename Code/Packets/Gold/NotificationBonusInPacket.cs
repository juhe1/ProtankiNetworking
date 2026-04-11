using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Gold;

public class NotificationBonusInPacket : Packet
{
	[Encode(0)]
	public string? Reason { get; set; }

	[Encode(1)]
	public Resource? SoundId { get; set; }

	public const int ID_CONST = -666893269;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
