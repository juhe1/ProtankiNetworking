using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Friends;

public class FriendsOnUsersLoadedInPacket : Packet
{

	public const int ID_CONST = -437587751;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
