using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Garage;

public class GarageEasterEggOutPacket : Packet
{

	[Encode(0)]
	public string? DecorName { get; set; }

	public const int ID_CONST = -163691268;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
