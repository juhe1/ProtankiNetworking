

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet to show a warning that the player is trying to join a team battle with wrong equipment.
/// </summary>
public class EquipmentNotMatchTeamConstraints : Packet
{
    [Encode(0)]
    public string? BattleTeamInfoObjectId { get; set; }

    public const int ID_CONST = -10847382;

    public override string Description =>
        "Warns that the player is trying to join a team battle with wrong equipment.";


}