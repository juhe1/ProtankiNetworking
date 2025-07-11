using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Garage;

/// <summary>
///     Mount an item in garage
/// </summary>
public class MountItem : AbstractPacket
{
    public const int ID_CONST = -1505530736;
    public override int Id => ID_CONST;
    public override string Description => "Mount an item in garage";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "item_id"
    };
}