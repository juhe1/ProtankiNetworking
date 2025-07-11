using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     A player has left the selected battle, from the preview screen
/// </summary>
public class LeftSelectedPreview : AbstractPacket
{
    public const int IdStatic = 1924874982;
    public override int Id => IdStatic;
    public override string Description => "A player has left the selected battle, from the preview screen";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "battleID",
        "username"
    };
}