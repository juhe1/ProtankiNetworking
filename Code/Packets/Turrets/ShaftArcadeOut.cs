using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Sends server details about a released Shaft arcade shot
/// </summary>
public class ShaftArcadeOut : Packet
{
	[Encode(0)]
	public int ClientTime { get; set; }

	[Encode(1)]
	public Vector3D? StaticHitPoint { get; set; }

	[Encode(2)]
	public string?[]? Targets { get; set; }

	[Encode(3)]
	public Vector3D?[]? TargetHitPoints { get; set; }

	[Encode(4)]
	public short[]? IncarnationIDs { get; set; }

	[Encode(5)]
	public Vector3D?[]? TargetBodyPositions { get; set; }

	[Encode(6)]
	public Vector3D?[]? GlobalHitPoints { get; set; }

	public const int ID_CONST = -2030760866;
	public override int Id => ID_CONST;
	public override string Description => "Sends server details about a released Shaft arcade shot";
}
