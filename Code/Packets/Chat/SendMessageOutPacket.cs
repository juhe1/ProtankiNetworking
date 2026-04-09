using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Chat;

public class SendMessageOutPacket : Packet
{

	[Encode(0)]
	public string? Username { get; set; }

	[Encode(1)]
	public string? Message { get; set; }

	public const int ID_CONST = 705454610;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
