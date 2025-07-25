using ProtankiNetworking.EncodableData;

// // Uncomment if ControlPointStateCodec is implemented

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for setting the state of a control point (pointId, state).
/// </summary>
public class SetPointState : Packet
{
	[Encode(0)]
	public int PointId { get; set; }

	[Encode(1)]
	public ControlPointState? State { get; set; }

	public const int ID_CONST = -1073178885;
	public override int Id => ID_CONST;
	public override string Description => "Set point state (pointId, state)";
}
