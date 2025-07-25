using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Sent when a player joins the currently-selected DM battle.
/// </summary>
public class JoinedSelectedDmBattle : Packet
{
    [Encode(0)]
    public string? BattleID { get; set; }

    [Encode(1)]
    public BattleInfoUser? UserInfo { get; set; }

    public const int ID_CONST = -911626491;
    public override int Id => ID_CONST;
    public override string Description => "Sent when a player joins the currently-selected DM battle.";


}