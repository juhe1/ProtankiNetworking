using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Friends;

public class FriendsLoadOutPacket : Packet
{

	public const int ID_CONST = -1590185083;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
