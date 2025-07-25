using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Turret rotation data from server
/// </summary>
public class TurretRotated : Packet
{
	[Encode(0)]
	public string? Username { get; set; }

	[Encode(1)]
	public TurretRotate? TurretRotation { get; set; }

	public const int ID_CONST = 1927704181;
	public override int Id => ID_CONST;
	public override string Description => "Turret rotation data from server";
}
