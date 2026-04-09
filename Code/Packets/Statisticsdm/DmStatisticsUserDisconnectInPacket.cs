using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Statisticsdm;

public class DmStatisticsUserDisconnectInPacket : Packet
{

	[Encode(0)]
	public string? UserId { get; set; }

	public const int ID_CONST = -1689876764;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
