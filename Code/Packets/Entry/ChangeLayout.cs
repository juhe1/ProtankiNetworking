using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Changes client layout/mode
/// </summary>
public class ChangeLayout : AbstractPacket
{
    public const int IdStatic = 1118835050;
    public override int Id => IdStatic;
    public override string Description => "Changes client layout/mode";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "layout"
    };
}