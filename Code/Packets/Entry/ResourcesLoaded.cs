namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Client callsback after finishes resource loading (NOT IMPLEMENTED)
/// </summary>
public class ResourcesLoaded : Packet
{
	[Encode(0)]
	public int CallbackId { get; set; }

	public const int ID_CONST = -82304134;
	public override int Id => ID_CONST;
	public override string Description =>
		"Client callsback after finishes resource loading (NOT IMPLEMENTED)";
}
