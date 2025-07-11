using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet indicating a friend's UID does not exist (no attributes).
/// </summary>
public class FriendsUidNotExist : AbstractPacket
{
    public const int IdStatic = -1490761936;
    public override int Id => IdStatic;
    public override string Description => "Friends UID not exist (no attributes)";
    public override BaseCodec[] CodecObjects => new BaseCodec[] { };
    public override string[] Attributes => new string[] { };
} 