using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Externalentrance;

public class CreateLinkForExistingUserOutPacket : Packet
{

	[Encode(0)]
	public string? Username { get; set; }

	[Encode(1)]
	public string? Password { get; set; }

	public const int ID_CONST = 0;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
