using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Battle user stats
/// </summary>
public class BattleUserTeamStats : Packet
{
	[Encode(0)]
	public UserStats? UsersStat { get; set; }

	[Encode(1)]
	public int Team { get; set; }

	public const int ID_CONST = -497293992;
	public override int Id => ID_CONST;
	public override string Description => "Battle user stats";
}
