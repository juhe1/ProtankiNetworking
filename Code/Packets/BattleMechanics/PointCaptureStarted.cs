using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for when a team starts capturing a point (team: BattleTeam).
/// </summary>
public class PointCaptureStarted : Packet
{
	[Encode(0)]
	public BattleTeam? Team { get; set; }

	public const int ID_CONST = -1346883037;
	public override int Id => ID_CONST;
	public override string Description => "Point capture started (team)";
}
