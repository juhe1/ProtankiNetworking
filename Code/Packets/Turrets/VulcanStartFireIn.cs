using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Vulcan start fire event.
/// </summary>
public class VulcanStartFireIn : AbstractPacket
{
    public const int ID_CONST = -1616602030;
    public override int Id => ID_CONST;
    public override string Description => "Vulcan start fire event";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance // shooterId
    };

    public override string[] Attributes => new[]
    {
        "shooterId"
    };
}