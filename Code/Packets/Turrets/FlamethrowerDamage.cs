using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Firebird attack
/// </summary>
public class FlamethrowerDamage : Packet
{
	[Encode(0)]
	public int ClientTime { get; set; }

	[Encode(1)]
	public string?[]? Targets { get; set; }

	[Encode(2)]
	public short[]? IncarnationIDs { get; set; }

	[Encode(3)]
	public Vector3D?[]? TargetBodyPositions { get; set; }

	[Encode(4)]
	public Vector3D?[]? TargetHitPoints { get; set; }

	public const int ID_CONST = 1395251766;
	public override int Id => ID_CONST;
	public override string Description => "Firebird attack";
}
