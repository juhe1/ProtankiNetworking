using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Freeze;

public class FreezeStartInPacket : Packet
{

	[Encode(0)]
	public string? Shooter { get; set; }

	public const int ID_CONST = -1171353580;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
