using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Bonusregion;

public class HideDropZoneInPacket : Packet
{

	[Encode(0)]
	public BonusRegionData? BonusRegion { get; set; }

	public const int ID_CONST = -1524095870;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
