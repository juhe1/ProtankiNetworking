using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for showing a drop zone (bonusRegion: BonusRegionData).
/// </summary>
public class ShowDropZone : Packet
{
    [Encode(0)]
    public BonusRegionData? BonusRegion { get; set; }

    public const int ID_CONST = -915079427;
    public override int Id => ID_CONST;
    public override string Description => "Show drop zone (bonusRegion: BonusRegionData)";


}