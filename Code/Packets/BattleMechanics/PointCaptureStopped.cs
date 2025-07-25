using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for when a team stops capturing a point (team: BattleTeam).
/// </summary>
public class PointCaptureStopped : Packet
{
	[Encode(0)]
	public BattleTeam? Team { get; set; }

	public const int ID_CONST = -1701488017;
	public override int Id => ID_CONST;
	public override string Description => "Point capture stopped (team)";
}
