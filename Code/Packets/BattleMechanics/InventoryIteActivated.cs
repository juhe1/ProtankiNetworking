using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for activated inventory item (itemId, time, decrease).
/// </summary>
public class InventoryIteActivated : AbstractPacket
{
    public static int IdStatic { get; } = 2032104949;
    public override int Id => IdStatic;
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