

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet indicating if a friend's UID exists (no attributes).
/// </summary>
public class FriendsUidExist : Packet
{
    public const int ID_CONST = -707501253;
    public override int Id => ID_CONST;
    public override string Description => "Friends UID exist (no attributes)";
} 