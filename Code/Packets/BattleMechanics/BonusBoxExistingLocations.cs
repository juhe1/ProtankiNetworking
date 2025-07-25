using System.Text.Json.Nodes;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Locations of existing bonus boxes
/// </summary>
public class BonusBoxExistingLocations : Packet
{
    [Encode(0)]
    public JsonNode? Json { get; set; }

    public const int ID_CONST = 870278784;
    public override int Id => ID_CONST;
    public override string Description => "Locations of existing bonus boxes";


}