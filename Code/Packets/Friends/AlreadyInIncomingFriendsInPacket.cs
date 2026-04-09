using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Friends;

public class AlreadyInIncomingFriendsInPacket : Packet
{

	[Encode(0)]
	public string? UserId { get; set; }

	public const int ID_CONST = -1258754138;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
