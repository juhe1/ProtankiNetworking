using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Changes client layout/mode
/// </summary>
public class ChangeLayout : Packet
{
	[Encode(0)]
	public LayoutState? Layout { get; set; }

	public const int ID_CONST = 1118835050;
	public override int Id => ID_CONST;
	public override string Description => "Changes client layout/mode";
}
