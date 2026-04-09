using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Tank;

public class MoveAndSetTurretStateInPacket : Packet
{

	[Encode(0)]
	public string? TankId { get; set; }

	[Encode(1)]
	public MoveCommand? Movement { get; set; }

	[Encode(2)]
	public float TurretDirection { get; set; }

	public const int ID_CONST = 1516578027;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
