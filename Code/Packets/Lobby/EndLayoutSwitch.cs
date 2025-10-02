using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for notifying about a layout state change.
/// </summary>
public class EndLayoutSwitch : Packet
{
	/// <summary>
	/// This is the second layout that is open behind the active layout.
	/// It can only be battle or same as CurrentState.
	/// So if you are in garage while in battle, this will be Battle.
	/// If you are for example in battle list without being in battle, this will be battle list.
	/// </summary>
	[Encode(0)]
	public LayoutState Origin { get; set; }

	/// <summary>
	/// Currently active layout.
	/// </summary>
	[Encode(1)]
	public LayoutState CurrentState { get; set; } // NOTE: in tanki online code this is named lastState.

	public const int ID_CONST = -593368100;
	public override int Id => ID_CONST;
	public override string Description => "Notifies about a layout state change";
}
