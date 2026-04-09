using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Garage;

public class ShowGarageCategoryInPacket : Packet
{

	[Encode(0)]
	public string? CategoryId { get; set; }

	public const int ID_CONST = 1318061480;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
