using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Send a battle invite to a player
/// </summary>
public class SendInvite : AbstractPacket
{
    public const int IdStatic = -864265623;
    public override int Id => IdStatic;
    public override string Description => "Send a battle invite to a player";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "username",
        "battleID"
    };
}