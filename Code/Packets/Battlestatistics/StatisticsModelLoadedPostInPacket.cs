using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battlestatistics;

public class StatisticsModelLoadedPostInPacket : Packet
{

	public const int ID_CONST = 1953272681;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
