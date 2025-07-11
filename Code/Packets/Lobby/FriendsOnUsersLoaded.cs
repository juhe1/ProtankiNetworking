using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for friends on users loaded (no attributes).
/// </summary>
public class FriendsOnUsersLoaded : AbstractPacket
{
    public const int ID_CONST = -437587751;
    public override int Id => ID_CONST;
    public override string Description => "Friends on users loaded (no attributes)";
    public override BaseCodec[] CodecObjects => new BaseCodec[] { };
    public override string[] Attributes => new string[] { };
} 