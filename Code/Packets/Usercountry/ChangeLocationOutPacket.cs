using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Usercountry;

public class ChangeLocationOutPacket : Packet
{

	[Encode(0)]
	public string? LocationAbbreviation { get; set; }

	public const int ID_CONST = 921004371;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
