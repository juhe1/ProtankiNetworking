using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Loads a tip item for loader window.
/// </summary>
public class LoadTipItemCC : AbstractPacket
{
    public const int IdStatic = 2094741924;
    public override int Id => IdStatic;
    public override string Description => "Load a tip item for loader window.";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "preview"
    };
}