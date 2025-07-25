

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Updates a player's score in a team battle preview
/// </summary>
public class UpdatePlayerTeamBattlePreview : Packet
{
    [Encode(0)]
    public string? BattleID { get; set; }

    [Encode(1)]
    public string? Username { get; set; }

    [Encode(2)]
    public int Score { get; set; }

    public const int ID_CONST = -375282889;
    public override int Id => ID_CONST;
    public override string Description => "Updates a player's score in a team battle preview";


}