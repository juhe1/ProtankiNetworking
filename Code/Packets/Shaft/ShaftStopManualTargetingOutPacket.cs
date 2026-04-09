using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Shaft;

public class ShaftStopManualTargetingOutPacket : Packet
{

	[Encode(0)]
	public int ClientTime { get; set; }

	public const int ID_CONST = -1527013252;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
