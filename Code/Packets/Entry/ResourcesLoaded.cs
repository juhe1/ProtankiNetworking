using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Client callsback after finishes resource loading (NOT IMPLEMENTED)
/// </summary>
public class ResourcesLoaded : AbstractPacket
{
    public const int IdStatic = -82304134;
    public override int Id => IdStatic;
    public override string Description => "Client callsback after finishes resource loading (NOT IMPLEMENTED)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "callbackId"
    };
}