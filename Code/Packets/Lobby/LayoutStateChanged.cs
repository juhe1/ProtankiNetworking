using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for notifying about a layout state change.
/// </summary>
public class LayoutStateChanged : Packet
{
	[Encode(0)]
	public LayoutState? Origin { get; set; }

	[Encode(1)]
	public LayoutState? LastState { get; set; }

	public const int ID_CONST = -593368100;
	public override int Id => ID_CONST;
	public override string Description => "Notifies about a layout state change";
}
