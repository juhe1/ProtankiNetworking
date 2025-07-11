using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for revoking a friend (userId).
/// </summary>
public class FriendsRevoke : AbstractPacket
{
    public static int IdStatic { get; } = 84050355;
    public override int Id => IdStatic;
    public override string Description => "Friends revoke (userId)";
    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance // userId
    };
    public override string[] Attributes => new[]
    {
        "userId"
    };
} 