using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Accepts a player's battle invite
/// </summary>
public class AcceptInvite : AbstractPacket
{
    public const int ID_CONST = 814687528;
    public override int Id => ID_CONST;
    public override string Description => "Accepts a player's battle invite";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "username"
    };
}