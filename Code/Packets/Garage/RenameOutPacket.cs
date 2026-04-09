using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Garage;

public class RenameOutPacket : Packet
{

	[Encode(0)]
	public string? NewName { get; set; }

	public const int ID_CONST = 0;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
