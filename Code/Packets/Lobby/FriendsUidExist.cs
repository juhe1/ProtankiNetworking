using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet indicating if a friend's UID exists (no attributes).
/// </summary>
public class FriendsUidExist : AbstractPacket
{
    public static int IdStatic { get; } = -707501253;
    public override int Id => IdStatic;
    public override string Description => "Friends UID exist (no attributes)";
    public override BaseCodec[] CodecObjects => new BaseCodec[] { };
    public override string[] Attributes => new string[] { };
} 