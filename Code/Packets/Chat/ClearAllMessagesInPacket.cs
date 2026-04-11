using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Chat;

public class ClearAllMessagesInPacket : Packet
{

	public const int ID_CONST = -1062190024;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
