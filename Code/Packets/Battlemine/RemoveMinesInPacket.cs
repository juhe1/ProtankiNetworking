using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battlemine;

public class RemoveMinesInPacket : Packet
{

	[Encode(0)]
	public string? OwnerId { get; set; }

	public const int ID_CONST = -1200619383;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
