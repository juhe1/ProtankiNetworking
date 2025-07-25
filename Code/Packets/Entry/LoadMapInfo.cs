using System.Text.Json.Nodes;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Information about all maps the client should load
/// </summary>
public class LoadMapInfo : Packet
{
	[Encode(0)]
	public JsonNode? Json { get; set; }

	public const int ID_CONST = -838186985;
	public override int Id => ID_CONST;
	public override string Description => "Information about all maps the client should load";
}
