using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Statisticsdm;

public class InitDMStatisticsInPacket : Packet
{

	[Encode(0)]
	public StatisticsDMCC? StatisticsDmCC { get; set; }

	public const int ID_CONST = -1959138292;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
