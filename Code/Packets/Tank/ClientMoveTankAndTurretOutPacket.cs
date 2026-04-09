using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Tank;

public class ClientMoveTankAndTurretOutPacket : Packet
{

	[Encode(0)]
	public int Time { get; set; }

	[Encode(1)]
	public short SpecificationId { get; set; }

	[Encode(2)]
	public MoveCommand? Movement { get; set; }

	[Encode(3)]
	public float TurretDirection { get; set; }

	public const int ID_CONST = -1683279062;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
