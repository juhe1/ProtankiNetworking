using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for loading team statistics (StatisticsTeamCC).
/// </summary>
public class LoadStatisticsTeamCC : Packet
{
	[Encode(0)]
	public int BlueScore { get; set; }

	[Encode(1)]
	public int RedScore { get; set; }

	[Encode(2)]
	public UserInfo?[]? UsersInfoBlue { get; set; }

	[Encode(3)]
	public UserInfo?[]? UsersInfoRed { get; set; }

	public const int ID_CONST = -1233891872;
	public override int Id => ID_CONST;
	public override string Description => "Load team statistics (StatisticsTeamCC)";
}
