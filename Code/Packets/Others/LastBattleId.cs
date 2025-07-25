

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Get the id of the last battle you selected
/// </summary>
public class LastBattleId : Packet
{
    [Encode(0)]
    public string? BattleId { get; set; }

    public const int ID_CONST = -602527073;
    public override int Id => ID_CONST;
    public override string Description => "Get the id of the last battle you selected";


}