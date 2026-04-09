using ProtankiNetworking.Codec;
using ProtankiNetworking.Packets;

namespace ProtankiNetworking.EncodableData;

public class StatisticsTeamCC : IEncodable
{
	public bool IsOptional { get; } = false;
	public bool IsArrayOptional { get; } = false;

	[Encode(0)]
	public int BlueScore { get; set; }

	[Encode(1)]
	public int RedScore { get; set; }

	[Encode(2)]
	public UserInfo?[]? UsersInfoBlue { get; set; }

	[Encode(3)]
	public UserInfo?[]? UsersInfoRed { get; set; }

}
