using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Locations of existing bonus boxes
/// </summary>
public class BonusBoxExistingLocations : AbstractPacket
{
    public const int ID_CONST = 870278784;
    public override int Id => ID_CONST;
    public override string Description => "Locations of existing bonus boxes";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        JsonCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "json"
    };
}