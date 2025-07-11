using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for loading referrer panel configuration (ReferrerPanelCC).
/// </summary>
public class LoadReferrerPanelCC : AbstractPacket
{
    public const int IdStatic = 832270655;
    public override int Id => IdStatic;
    public override string Description => "Load referrer panel configuration (ReferrerPanelCC)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance, // hash
        StringCodec.Instance // host
    };

    public override string[] Attributes => new[]
    {
        "hash",
        "host"
    };
}