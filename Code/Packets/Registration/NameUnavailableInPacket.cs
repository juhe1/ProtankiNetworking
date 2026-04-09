using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Registration;

public class NameUnavailableInPacket : Packet
{

	[Encode(0)]
	public string?[]? Usernames { get; set; }

	public const int ID_CONST = 442888643;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
