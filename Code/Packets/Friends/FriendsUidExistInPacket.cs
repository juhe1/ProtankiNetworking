using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Friends;

public class FriendsUidExistInPacket : Packet
{

	public const int ID_CONST = -707501253;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
