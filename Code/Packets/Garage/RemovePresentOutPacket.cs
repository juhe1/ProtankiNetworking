using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Garage;

public class RemovePresentOutPacket : Packet
{

	[Encode(0)]
	public int PresentId { get; set; }

	public const int ID_CONST = -2001666558;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
