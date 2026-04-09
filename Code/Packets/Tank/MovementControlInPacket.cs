using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Tank;

public class MovementControlInPacket : Packet
{

	[Encode(0)]
	public string? TankId { get; set; }

	[Encode(1)]
	public byte Control { get; set; }

	public const int ID_CONST = -301298508;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
