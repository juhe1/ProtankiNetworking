using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Statisticsdm;

public class ChangeUserStatInPacket : Packet
{

	[Encode(0)]
	public UserStat? UserStats { get; set; }

	public const int ID_CONST = 696140460;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
