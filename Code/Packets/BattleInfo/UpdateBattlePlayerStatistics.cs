using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Updates the in-battle statistics of a player.
/// </summary>
public class UpdateBattlePlayerStatistics : Packet
{
	[Encode(0)]
	public UserStats? UserStats { get; set; }

	public const int ID_CONST = 696140460;
	public override int Id => ID_CONST;
	public override string Description => "Updates the in-battle statistics of a player.";
}
