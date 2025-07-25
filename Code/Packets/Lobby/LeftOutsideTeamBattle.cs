

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Remove this player from the friends count in team status
/// </summary>
public class LeftOutsideTeamBattle : Packet
{
    [Encode(0)]
    public string? BattleID { get; set; }

    [Encode(1)]
    public string? Username { get; set; }

    public const int ID_CONST = 1447204641;
    public override int Id => ID_CONST;
    public override string Description => "Remove this player from the friends count in team status";


}