using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Garage;

public class LoadOwnedGarageItemsInPacket : Packet
{

	[Encode(0)]
	public string? BattlesJson { get; set; }

	public const int ID_CONST = -255516505;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
