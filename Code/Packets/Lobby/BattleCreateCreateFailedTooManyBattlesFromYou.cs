

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for battle creation failed due to too many battles from the user (no attributes).
/// </summary>
public class BattleCreateCreateFailedTooManyBattlesFromYou : Packet
{
    public const int ID_CONST = -614313838;
    public override int Id => ID_CONST;
    public override string Description => "Battle create failed: too many battles from you (no attributes)";
} 