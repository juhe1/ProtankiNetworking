using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for outgoing friend adding (user).
/// </summary>
public class FriendsOutgoingOnAdding : AbstractPacket
{
    public static int IdStatic { get; } = -1241704092;
    public override int Id => IdStatic;
    public override string Description => "Friends outgoing on adding (user)";
    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance // user
    };
    public override string[] Attributes => new[]
    {
        "user"
    };
} 