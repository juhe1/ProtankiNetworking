using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Player Equipment.
/// </summary>
public class PlayerEquipment : AbstractPacket
{
    public const int ID_CONST = -1643824092;
    public override int Id => ID_CONST;
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