using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Controlpoints;

public class TankLeftPointZoneInPacket : Packet
{

	[Encode(0)]
	public int PointId { get; set; }

	[Encode(1)]
	public string? TankId { get; set; }

	public const int ID_CONST = -1410197917;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
