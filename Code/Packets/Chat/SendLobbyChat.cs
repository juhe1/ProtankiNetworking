using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Chat;

/// <summary>
///     Sends a chat message to the lobby
/// </summary>
public class SendLobbyChat : AbstractPacket
{
    public const int ID_CONST = 705454610;
    public override int Id => ID_CONST;
    public override string Description => "Sends a chat message to the lobby";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "username",
        "message"
    };
}