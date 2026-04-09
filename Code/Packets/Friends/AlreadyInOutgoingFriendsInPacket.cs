using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Friends;

public class AlreadyInOutgoingFriendsInPacket : Packet
{

	[Encode(0)]
	public string? UserId { get; set; }

	public const int ID_CONST = 2064692768;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
