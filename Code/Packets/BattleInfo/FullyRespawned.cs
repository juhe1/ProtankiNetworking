

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Packet sent when the player has fully respawned
/// </summary>
public class FullyRespawned : Packet
{
    [Encode(0)]
    public string? Username { get; set; }

    public const int ID_CONST = 1868573511;
    public override int Id => ID_CONST;
    public override string Description => "Packet sent when the player has fully respawned";


}