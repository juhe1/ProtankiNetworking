

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Reject a player's battle invite
/// </summary>
public class RejectInvite : Packet
{
    [Encode(0)]
    public string? Username { get; set; }

    public const int ID_CONST = 1152865919;
    public override int Id => ID_CONST;
    public override string Description => "Reject a player's battle invite";


}