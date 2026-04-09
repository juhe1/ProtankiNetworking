using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battlestatistics;

public class InitStatisticsInPacket : Packet
{

	[Encode(0)]
	public StatisticsModelCC? StatisticsModelCC { get; set; }

	public const int ID_CONST = 522993449;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
