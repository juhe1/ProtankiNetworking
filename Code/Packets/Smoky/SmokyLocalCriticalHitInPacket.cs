using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Smoky;

public class SmokyLocalCriticalHitInPacket : Packet
{

	[Encode(0)]
	public string? Target { get; set; }

	public const int ID_CONST = -671618989;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
