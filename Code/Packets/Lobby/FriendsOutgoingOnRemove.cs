using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for outgoing friend removal (user).
/// </summary>
public class FriendsOutgoingOnRemove : AbstractPacket
{
    public const int ID_CONST = 614714702;
    public override int Id => ID_CONST;
    public override string Description => "Friends outgoing on remove (user)";
    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance // user
    };
    public override string[] Attributes => new[]
    {
        "user"
    };
} 