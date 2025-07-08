using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Player Equipment.
/// </summary>
public class PlayerEquipment : AbstractPacket
{
    public static int Id { get; } = -1643824092;
    public override string Description => "Player Equipment.";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        JsonCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "json"
    };
}