using System.Text.Json.Nodes;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Server tells us what resources to load
/// </summary>
public class LoadResources : Packet
{
	[Encode(0)]
	public JsonNode? Json { get; set; }

	[Encode(1)]
	public int CallbackID { get; set; }

	public const int ID_CONST = -1797047325;
	public override int Id => ID_CONST;
	public override string Description => "Server tells us what resources to load";
}
