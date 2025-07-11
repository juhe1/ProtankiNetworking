using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Information about all maps the client should load
/// </summary>
public class LoadMapInfo : AbstractPacket
{
    public static int IdStatic { get; } = -838186985;
    public override int Id => IdStatic;
    public override string Description => "Information about all maps the client should load";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        JsonCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "json"
    };
}