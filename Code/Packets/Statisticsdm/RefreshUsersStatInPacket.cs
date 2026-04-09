using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Statisticsdm;

public class RefreshUsersStatInPacket : Packet
{

	[Encode(0)]
	public UserStat?[]? UserStats { get; set; }

	public const int ID_CONST = 1061006142;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
