using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Sent when a player joins the currently-selected Team battle.
/// </summary>
public class JoinedSelectedTeamBattle : Packet
{
    [Encode(0)]
    public string? BattleID { get; set; }

    [Encode(1)]
    public BattleInfoUser? UserInfo { get; set; }

    [Encode(2)]
    public int Team { get; set; }

    public const int ID_CONST = 118447426;
    public override int Id => ID_CONST;
    public override string Description => "Sent when a player joins the currently-selected Team battle.";


}