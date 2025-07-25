

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Accepts a player's battle invite
/// </summary>
public class AcceptInvite : Packet
{
    [Encode(0)]
    public string? Username { get; set; }

    public const int ID_CONST = 814687528;
    public override int Id => ID_CONST;
    public override string Description => "Accepts a player's battle invite";


}