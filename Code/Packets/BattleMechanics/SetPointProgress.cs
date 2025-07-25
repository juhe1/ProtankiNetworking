namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for setting point progress (pointId, progress, progressSpeed).
/// </summary>
public class SetPointProgress : Packet
{
	[Encode(0)]
	public int PointId { get; set; }

	[Encode(1)]
	public float Progress { get; set; }

	[Encode(2)]
	public float ProgressSpeed { get; set; }

	public const int ID_CONST = -2141998253;
	public override int Id => ID_CONST;
	public override string Description => "Set point progress (pointId, progress, progressSpeed)";
}
