using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Battle User Rewards
/// </summary>
public class BattleUserRewards : Packet
{
	[Encode(0)]
	public BattleUserRewardsData?[]? Reward { get; set; }

	[Encode(1)]
	public int TimeToRestart { get; set; }

	public const int ID_CONST = 560336625;
	public override int Id => ID_CONST;
	public override string Description => "Battle User Rewards";
}
