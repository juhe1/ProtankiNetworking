using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Tank;

public class MoveTankInPacket : Packet
{

	[Encode(0)]
	public string? TankId { get; set; }

	[Encode(1)]
	public MoveCommand? Movement { get; set; }

	public const int ID_CONST = -64696933;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
