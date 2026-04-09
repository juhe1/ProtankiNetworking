using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Externalentrance;

public class ExternalRegisterNewUserOutPacket : Packet
{

	[Encode(0)]
	public string? Username { get; set; }

	public const int ID_CONST = -653665247;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
