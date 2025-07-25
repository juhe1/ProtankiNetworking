

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Swaps teams in a battle
/// </summary>
public class SwapTeams : Packet
{
    [Encode(0)]
    public string? BattleID { get; set; }

    public const int ID_CONST = -994817471;
    public override int Id => ID_CONST;
    public override string Description => "Swaps teams in a battle";


}