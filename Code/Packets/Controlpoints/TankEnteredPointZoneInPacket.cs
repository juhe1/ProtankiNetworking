using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Controlpoints;

public class TankEnteredPointZoneInPacket : Packet
{

	[Encode(0)]
	public int PointId { get; set; }

	[Encode(1)]
	public string? TankId { get; set; }

	public const int ID_CONST = -456245145;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
