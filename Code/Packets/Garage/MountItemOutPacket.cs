using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Garage;

public class MountItemOutPacket : Packet
{

	[Encode(0)]
	public string? ItemId { get; set; }

	public const int ID_CONST = 0;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
