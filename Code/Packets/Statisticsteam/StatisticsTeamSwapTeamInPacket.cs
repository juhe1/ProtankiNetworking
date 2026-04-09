using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Statisticsteam;

public class StatisticsTeamSwapTeamInPacket : Packet
{

	[Encode(0)]
	public UserStat?[]? TeamAUserStats { get; set; }

	[Encode(1)]
	public UserStat?[]? TeamBUserStats { get; set; }

	public const int ID_CONST = -1668779175;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
