

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for outgoing friend adding (user).
/// </summary>
public class FriendsOutgoingOnAdding : Packet
{
    [Encode(0)]
    public string? User { get; set; }

    public const int ID_CONST = -1241704092;
    public override int Id => ID_CONST;
    public override string Description => "Friends outgoing on adding (user)";
} 