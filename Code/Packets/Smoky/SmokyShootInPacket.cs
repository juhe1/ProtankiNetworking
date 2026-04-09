using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Smoky;

public class SmokyShootInPacket : Packet
{

	[Encode(0)]
	public string? Shooter { get; set; }

	public const int ID_CONST = -1032328347;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
