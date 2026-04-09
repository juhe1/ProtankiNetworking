using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battlechat;

public class BattleChatUpdateTeamHeaderInPacket : Packet
{

	[Encode(0)]
	public string? Header { get; set; }

	public const int ID_CONST = -1331361684;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
