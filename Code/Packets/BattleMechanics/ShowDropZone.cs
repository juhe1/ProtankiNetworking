using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Custom;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for showing a drop zone (bonusRegion: BonusRegionData).
/// </summary>
public class ShowDropZone : AbstractPacket
{
    public static int IdStatic { get; } = -915079427;
    public override int Id => IdStatic;
    public override string Description => "Show drop zone (bonusRegion: BonusRegionData)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        BonusRegionDataCodec.Instance // bonusRegion
    };

    public override string[] Attributes => new[]
    {
        "bonusRegion"
    };
}