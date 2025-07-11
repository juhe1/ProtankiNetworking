using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for adding a friend (userId).
/// </summary>
public class FriendsAdd : AbstractPacket
{
    public const int ID_CONST = -1457773660;
    public override int Id => ID_CONST;
    public override string Description => "Friends add (userId)";
    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance // userId
    };
    public override string[] Attributes => new[]
    {
        "userId"
    };
} 