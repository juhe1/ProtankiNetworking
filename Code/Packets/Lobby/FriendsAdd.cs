using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for adding a friend (userId).
/// </summary>
public class FriendsAdd : AbstractPacket
{
    public const int IdStatic = -1457773660;
    public override int Id => IdStatic;
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