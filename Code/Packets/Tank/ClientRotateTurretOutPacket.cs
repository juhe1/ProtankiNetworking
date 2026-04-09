using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Tank;

public class ClientRotateTurretOutPacket : Packet
{

	[Encode(0)]
	public int Time { get; set; }

	[Encode(1)]
	public RotateTurretCommand? TurretRotation { get; set; }

	[Encode(2)]
	public short IncarnationId { get; set; }

	public const int ID_CONST = -114968993;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
