using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;

namespace ProtankiNetworking.Packets.Chat;

/// <summary>
///     Receives chat messages from the lobby
/// </summary>
public class ReceiveLobbyChat : AbstractPacket
{
    public const int ID_CONST = -1263520410;
    public override int Id => ID_CONST;
    public override string Description => "Receives chat messages from the lobby";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        new VectorCodec(ChatMessageCodec.Instance, false)
    };

    public override string[] Attributes => new[]
    {
        "messages"
    };
}