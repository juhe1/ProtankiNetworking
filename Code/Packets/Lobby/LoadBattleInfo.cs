using System.Text.Json.Nodes;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Loads detailed battle information
/// </summary>
public class LoadBattleInfo : Packet
{
    [Encode(0)]
    public JsonNode? Json { get; set; }

    public const int ID_CONST = 546722394;
    public override int Id => ID_CONST;
    public override string Description => "Loads detailed battle information";


}