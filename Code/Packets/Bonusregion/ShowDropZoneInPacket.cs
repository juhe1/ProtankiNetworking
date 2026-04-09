using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Bonusregion;

public class ShowDropZoneInPacket : Packet
{

	[Encode(0)]
	public BonusRegionData? BonusRegion { get; set; }

	public const int ID_CONST = -915079427;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
