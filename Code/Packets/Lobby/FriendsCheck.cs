using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for checking a friend (userId).
/// </summary>
public class FriendsCheck : AbstractPacket
{
    public const int IdStatic = 126880779;
    public override int Id => IdStatic;
    public override string Description => "Friends check (userId)";
    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance // userId
    };
    public override string[] Attributes => new[]
    {
        "userId"
    };
} 