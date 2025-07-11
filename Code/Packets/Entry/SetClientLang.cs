using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Sets client language
/// </summary>
public class SetClientLang : AbstractPacket
{
    public const int ID_CONST = -1864333717;
    public override int Id => ID_CONST;
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