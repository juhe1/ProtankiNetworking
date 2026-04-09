using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Shaft;

public class ShaftStopManualTargetingInPacket : Packet
{

	[Encode(0)]
	public string? Shooter { get; set; }

	public const int ID_CONST = -1380283560;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
