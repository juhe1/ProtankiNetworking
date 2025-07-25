using System.Text.Json.Nodes;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Load Owned Garage Items
/// </summary>
public class LoadOwnedGarageItems : Packet
{
	[Encode(0)]
	public JsonNode? Json { get; set; }

	public const int ID_CONST = -255516505;
	public override int Id => ID_CONST;
	public override string Description => "Load Owned Garage Items";
}
