using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Vulcan start fire event.
/// </summary>
public class VulcanStartFireIn : AbstractPacket
{
    public static int IdStatic { get; } = -1616602030;
    public override int Id => IdStatic;
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