using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Chat;

public class LoadChatModelInPacket : Packet
{

	[Encode(0)]
	public ChatCC? Cc { get; set; }

	public const int ID_CONST = 178154988;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
