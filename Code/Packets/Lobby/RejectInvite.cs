using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Reject a player's battle invite
/// </summary>
public class RejectInvite : AbstractPacket
{
    public const int ID_CONST = 1152865919;
    public override int Id => ID_CONST;
    public override string Description => "Reject a player's battle invite";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "username"
    };
}