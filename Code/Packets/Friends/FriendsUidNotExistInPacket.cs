using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Friends;

public class FriendsUidNotExistInPacket : Packet
{

	public const int ID_CONST = -1490761936;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
