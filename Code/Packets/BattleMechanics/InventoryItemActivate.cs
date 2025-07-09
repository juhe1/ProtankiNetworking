using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for activating an inventory item (itemId).
/// </summary>
public class InventoryItemActivate : AbstractPacket
{
    public static int IdStatic { get; } = -2102525054;
    public override int Id => IdStatic;
    public override string Description => "Inventory item activate (itemId)";
    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance // itemId
    };
    public override string[] Attributes => new[]
    {
        "itemId"
    };
} 