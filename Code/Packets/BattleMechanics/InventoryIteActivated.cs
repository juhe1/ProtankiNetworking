using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for activated inventory item (itemId, time, decrease).
/// </summary>
public class InventoryIteActivated : AbstractPacket
{
    public const int ID_CONST = 2032104949;
    public override int Id => ID_CONST;
    public override string Description => "Inventory item activated (itemId, time, decrease)";
    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance, // itemId
        IntCodec.Instance,    // time
        BoolCodec.Instance    // decrease
    };
    public override string[] Attributes => new[]
    {
        "itemId",
        "time",
        "decrease"
    };
} 