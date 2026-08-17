using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.BlockValidator;

public class YouAreBlockedInPacket : Packet
{

	[Encode(0)]
	public string? Reason { get; set; }

	public const int ID_CONST = -600078553;
	public override int Id => ID_CONST;
	public override string Description => "Informs the client that the user has been blocked and provides the reason.";
}
