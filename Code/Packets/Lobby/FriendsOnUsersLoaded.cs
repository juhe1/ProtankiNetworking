using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for friends on users loaded (no attributes).
/// </summary>
public class FriendsOnUsersLoaded : AbstractPacket
{
    public const int IdStatic = -437587751;
    public override int Id => IdStatic;
    public override string Description => "Friends on users loaded (no attributes)";
    public override BaseCodec[] CodecObjects => new BaseCodec[] { };
    public override string[] Attributes => new string[] { };
} 