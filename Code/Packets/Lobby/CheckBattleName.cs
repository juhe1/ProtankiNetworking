

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Censors invalid battle names
/// </summary>
public class CheckBattleName : Packet
{
    [Encode(0)]
    public string? BattleName { get; set; }

    public const int ID_CONST = 566652736;
    public override int Id => ID_CONST;
    public override string Description => "Censors invalid battle names";


}