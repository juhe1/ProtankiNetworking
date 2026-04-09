using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Registration;

public class CheckNameAvailabilityOutPacket : Packet
{

	[Encode(0)]
	public string? Username { get; set; }

	public const int ID_CONST = 1083705823;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
