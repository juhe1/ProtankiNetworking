using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Chat;

/// <summary>
///     Sends a chat message to the lobby
/// </summary>
public class SendLobbyChat : AbstractPacket
{
    public static int IdStatic { get; } = 705454610;
    public override int Id => IdStatic;
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