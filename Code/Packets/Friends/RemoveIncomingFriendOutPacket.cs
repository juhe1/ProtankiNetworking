using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Friends;

public class RemoveIncomingFriendOutPacket : Packet
{

	[Encode(0)]
	public string? UserId { get; set; }

	public const int ID_CONST = 650923390;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
