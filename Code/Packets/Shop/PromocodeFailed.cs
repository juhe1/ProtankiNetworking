using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.Shop;

/// <summary>
///     Incorrect or expired promocode
/// </summary>
public class PromocodeFailed : AbstractPacket
{
    public const int ID_CONST = -1850050333;
    public override int Id => ID_CONST;
    public override string Description => "Incorrect or expired promocode";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}