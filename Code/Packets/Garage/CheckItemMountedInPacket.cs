using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Garage;

public class CheckItemMountedInPacket : Packet
{

	[Encode(0)]
	public string? ItemId { get; set; }

	[Encode(1)]
	public bool Mounted { get; set; }

	public const int ID_CONST = 2062201643;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
