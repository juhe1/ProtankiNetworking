using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Vulcan stop fire event.
/// </summary>
public class VulcanStopFireIn : AbstractPacket
{
    public const int ID_CONST = 133452238;
    public override int Id => ID_CONST;
    public override string Description => "Vulcan stop fire event";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance // shooterId
    };

    public override string[] Attributes => new[]
    {
        "shooterId"
    };
}