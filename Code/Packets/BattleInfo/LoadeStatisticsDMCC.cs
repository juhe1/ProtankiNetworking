using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Packet for loading DM statistics (usersInfo: Vector<UserInfo>).
/// </summary>
public class LoadeStatisticsDMCC : Packet
{
	[Encode(0)]
	public UserInfo?[]? UsersInfo { get; set; }

	public const int ID_CONST = -1959138292;
	public override int Id => ID_CONST;
	public override string Description => "Load DM statistics (usersInfo: Vector<UserInfo>)";
}
