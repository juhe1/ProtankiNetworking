using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Statisticsdm;

public class DmStatisticsUserConnectInPacket : Packet
{

	[Encode(0)]
	public string? UserId { get; set; }

	[Encode(1)]
	public UserInfo?[]? UserInfos { get; set; }

	public const int ID_CONST = 862913394;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
