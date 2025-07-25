

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet to show a warning that the player is trying to join with wrong equipment into DM battle.
/// </summary>
public class EquipmentNotMatchConstraints : Packet
{
    [Encode(0)]
    public string? BattleDMInfoObjectId { get; set; }

    public const int ID_CONST = 1229594925;

    public override string Description =>
        "Warns that the player is trying to join with wrong equipment into DM battle.";


}