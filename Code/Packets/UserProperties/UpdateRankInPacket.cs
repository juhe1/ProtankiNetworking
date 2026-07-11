using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.UserProperties;

public class UpdateRankInPacket : Packet
{

	[Encode(0)]
	public int Rank { get; set; }

	[Encode(1)]
	public int Score { get; set; }

	[Encode(2)]
	public int CurrentRankScore { get; set; }

	[Encode(3)]
	public int NextScore { get; set; }

	[Encode(4)]
	public int CrystalGift { get; set; }

	public const int ID_CONST = 1989173907;
	public override int Id => ID_CONST;
	public override string Description => "Updates the user rank shown in the panel and shows rank up notice.";
}
