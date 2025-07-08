using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleMechanics
{
    /// <summary>
    /// Packet for showing a drop zone (bonusRegion: BonusRegionData).
    /// </summary>
    public class ShowDropZone : AbstractPacket
    {
        public static int Id { get; } = -915079427;
        public override string Description => "Show drop zone (bonusRegion: BonusRegionData)";
        public override BaseCodec[] CodecObjects => new BaseCodec[]
        {
            BonusRegionDataCodec.Instance, // bonusRegion
        };
        public override string[] Attributes => new string[]
        {
            "bonusRegion",
        };
    }
} 