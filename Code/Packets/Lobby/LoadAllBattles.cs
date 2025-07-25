using System.Text.Json.Nodes;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Loads all current battles
/// </summary>
public class LoadAllBattles : Packet
{
    [Encode(0)]
    public JsonNode? BattlesJson { get; set; }

    public const int ID_CONST = 552006706;
    public override int Id => ID_CONST;
    public override string Description => "Loads all current battles";


}