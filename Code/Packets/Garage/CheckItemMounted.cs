using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Garage;

/// <summary>
///     If the mount was successful or not
/// </summary>
public class CheckItemMounted : AbstractPacket
{
    public const int ID_CONST = 2062201643;
    public override int Id => ID_CONST;
    public override string Description => "If the mount was successful or not";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        BoolCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "item_id",
        "mounted"
    };
}