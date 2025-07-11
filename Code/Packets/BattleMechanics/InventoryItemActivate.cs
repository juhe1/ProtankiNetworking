using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for activating an inventory item (itemId).
/// </summary>
public class InventoryItemActivate : AbstractPacket
{
    public const int ID_CONST = -2102525054;
    public override int Id => ID_CONST;
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