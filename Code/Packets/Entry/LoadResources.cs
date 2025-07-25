using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Server tells us what resources to load
/// </summary>
public class LoadResources : AbstractPacket
{
    public const int ID_CONST = -1797047325;
    public override int Id => ID_CONST;
    public override string Description => "Server tells us what resources to load";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        JsonCodec.Instance,
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "json",
        "callbackID"
    };
}