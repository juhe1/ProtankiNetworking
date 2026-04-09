using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Friends;

public class LoadFriendsListInPacket : Packet
{

	[Encode(0)]
	public UserContainerCC? FriendsAcceptedCC { get; set; }

	[Encode(1)]
	public UserContainerCC? FriendsAcceptedNotificatorCC { get; set; }

	[Encode(2)]
	public UserContainerCC? FriendsIncomingCC { get; set; }

	[Encode(3)]
	public UserContainerCC? FriendsIncomingNotificatorCC { get; set; }

	[Encode(4)]
	public UserContainerCC? FriendsOutgoingCC { get; set; }

	public const int ID_CONST = 1422563374;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
