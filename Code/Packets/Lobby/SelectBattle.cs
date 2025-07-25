

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Client selects a battle / Server confirms selection of battle
/// </summary>
public class SelectBattle : Packet
{
    [Encode(0)]
    public string? BattleID { get; set; }

    public const int ID_CONST = 2092412133;
    public override int Id => ID_CONST;
    public override string Description => "Client selects a battle / Server confirms selection of battle";


}