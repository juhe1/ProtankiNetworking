using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for navigating to a URL (url).
/// </summary>
public class NavigateToURL : AbstractPacket
{
    public static int IdStatic { get; } = -1455955413;
    public override int Id => IdStatic;
    public override string Description => "Navigate to URL (url)";
    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance // url
    };
    public override string[] Attributes => new[]
    {
        "url"
    };
} 