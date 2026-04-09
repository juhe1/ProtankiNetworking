using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Tank;

public class RotateTurretInPacket : Packet
{

	[Encode(0)]
	public string? TankId { get; set; }

	[Encode(1)]
	public RotateTurretCommand? TurretRotation { get; set; }

	public const int ID_CONST = 1927704181;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
