using System.Text.Json.Nodes;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Loads limited info about a newly created battle
/// </summary>
public class BattleCreated : Packet
{
	[Encode(0)]
	public JsonNode? Json { get; set; }

	public const int ID_CONST = 802300608;
	public override int Id => ID_CONST;
	public override string Description => "Loads limited info about a newly created battle";
}
