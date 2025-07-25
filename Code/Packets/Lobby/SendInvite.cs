

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Send a battle invite to a player
/// </summary>
public class SendInvite : Packet
{
    [Encode(0)]
    public string? Username { get; set; }

    [Encode(1)]
    public string? BattleID { get; set; }

    public const int ID_CONST = -864265623;
    public override int Id => ID_CONST;
    public override string Description => "Send a battle invite to a player";


}