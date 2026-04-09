using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Friends;

public class OutgoingOnAddingInPacket : Packet
{

	[Encode(0)]
	public string? UserId { get; set; }

	public const int ID_CONST = -1241704092;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
