using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Statisticsteam;

public class StatisticsTeamUserLeftInPacket : Packet
{

	[Encode(0)]
	public string? UserId { get; set; }

	public const int ID_CONST = 1411656080;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
