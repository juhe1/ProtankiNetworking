

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     A player has left a team battle, the observer being within the battle
/// </summary>
public class LeftInsideTeamBattle : Packet
{
    [Encode(0)]
    public string? Username { get; set; }

    public const int ID_CONST = 1411656080;
    public override int Id => ID_CONST;
    public override string Description => "A player has left a team battle, the observer being within the battle";


}