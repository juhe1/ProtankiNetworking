using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Bonusregion;

public class LoadBonusRegionsModelInPacket : Packet
{

	[Encode(0)]
	public BonusRegionsCC? Cc { get; set; }

	public const int ID_CONST = -959048700;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
