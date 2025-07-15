using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Custom;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Changes client layout/mode
/// </summary>
public class ChangeLayout : AbstractPacket
{
    public const int ID_CONST = 1118835050;
    public override int Id => ID_CONST;
    public override string Description => "Changes client layout/mode";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        LayoutStateCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "layout"
    };
}