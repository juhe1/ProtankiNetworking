using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Chat;

/// <summary>
///     Wipes all messages by a user in the lobby
/// </summary>
public class WipeLobbyMessages : AbstractPacket
{
    public static int IdStatic { get; } = 1993050216;
    public override int Id => IdStatic;
    public override string Description => "Wipes all messages by a user in the lobby";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "username"
    };
}