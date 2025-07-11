using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Shop;

/// <summary>
///     Promocode applied successfully
/// </summary>
public class PromocodeSuccess : AbstractPacket
{
    public static int IdStatic { get; } = -1859441081;
    public override int Id => IdStatic;
    public override string Description => "Promocode applied successfully";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}