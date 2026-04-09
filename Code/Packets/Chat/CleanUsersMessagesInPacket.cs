using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Chat;

public class CleanUsersMessagesInPacket : Packet
{

	[Encode(0)]
	public string? Username { get; set; }

	public const int ID_CONST = 1993050216;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
