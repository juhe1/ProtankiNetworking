

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     The existing battle round has finished
/// </summary>
public class RoundFinish : Packet
{
    [Encode(0)]
    public string? BattleID { get; set; }

    public const int ID_CONST = 1534651002;
    public override int Id => ID_CONST;
    public override string Description => "The existing battle round has finished";


}