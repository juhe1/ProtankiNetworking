using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Tank;

public class SetSpecificationInPacket : Packet
{

	[Encode(0)]
	public string? TankId { get; set; }

	[Encode(1)]
	public float MaxSpeed { get; set; }

	[Encode(2)]
	public float MaxTurnSpeed { get; set; }

	[Encode(3)]
	public float MaxTurretRotationSpeed { get; set; }

	[Encode(4)]
	public float Acceleration { get; set; }

	[Encode(5)]
	public short SpecificationId { get; set; }

	public const int ID_CONST = -1672577397;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
