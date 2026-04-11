using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Chat;

public class UnloadChatInPacket : Packet
{

	public const int ID_CONST = -920985123;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
