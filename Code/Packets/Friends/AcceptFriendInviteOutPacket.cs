using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Friends;

public class AcceptFriendInviteOutPacket : Packet
{

	[Encode(0)]
	public string? UserId { get; set; }

	public const int ID_CONST = -1926185291;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
