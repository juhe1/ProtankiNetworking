using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Sets client language
/// </summary>
public class SetClientLang : AbstractPacket
{
    public static int IdStatic { get; } = -1864333717;
    public override int Id => IdStatic;
    public override string Description => "Sets client language";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "lang"
    };
}