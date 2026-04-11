using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Shaft;

public class ShaftActivateManualTargetingOutPacket : Packet
{

	public const int ID_CONST = -1487306515;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
