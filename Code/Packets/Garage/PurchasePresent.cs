using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Garage;

public class PurchasePresent : Packet
{

	[Encode(0)]
	public string? Uid { get; set; }

	[Encode(1)]
	public string? PresentName { get; set; }

	[Encode(2)]
	public string? Text { get; set; }

	[Encode(3)]
	public int Cost { get; set; }

	public const int ID_CONST = -1518850075;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
