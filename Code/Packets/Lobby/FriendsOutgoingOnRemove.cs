

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for outgoing friend removal (user).
/// </summary>
public class FriendsOutgoingOnRemove : Packet
{
    [Encode(0)]
    public string? User { get; set; }

    public const int ID_CONST = 614714702;
    public override int Id => ID_CONST;
    public override string Description => "Friends outgoing on remove (user)";
} 