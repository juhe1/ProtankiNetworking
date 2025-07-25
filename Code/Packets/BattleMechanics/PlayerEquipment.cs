using System.Text.Json.Nodes;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Player Equipment.
/// </summary>
public class PlayerEquipment : Packet
{
    [Encode(0)]
    public JsonNode? Json { get; set; }

    public const int ID_CONST = -1643824092;
    public override int Id => ID_CONST;
    public override string Description => "Player Equipment.";


}