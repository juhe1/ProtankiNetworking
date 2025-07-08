using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Buy from shop
/// </summary>
public class ChangeLocation : AbstractPacket
{
    public static int IdStatic { get; } = 921004371;
    public override int Id => IdStatic;
    public override string Description => "Buy from shop";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "location_abbreviation"
    };
}