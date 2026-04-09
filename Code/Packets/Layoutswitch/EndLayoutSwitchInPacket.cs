using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Layoutswitch;

public class EndLayoutSwitchInPacket : Packet
{

	[Encode(0)]
	public LayoutState? Origin { get; set; }

	[Encode(1)]
	public LayoutState? CurrentState { get; set; }

	public const int ID_CONST = -593368100;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
