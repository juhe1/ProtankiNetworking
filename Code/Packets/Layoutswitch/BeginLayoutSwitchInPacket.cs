using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Layoutswitch;

public class BeginLayoutSwitchInPacket : Packet
{

	[Encode(0)]
	public LayoutState? CurrentState { get; set; }

	public const int ID_CONST = 1118835050;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
