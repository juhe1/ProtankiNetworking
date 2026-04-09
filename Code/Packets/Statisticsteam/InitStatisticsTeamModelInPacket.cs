using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Statisticsteam;

public class InitStatisticsTeamModelInPacket : Packet
{

	[Encode(0)]
	public StatisticsTeamCC? StatisticsTeamCC { get; set; }

	public const int ID_CONST = -1233891872;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
