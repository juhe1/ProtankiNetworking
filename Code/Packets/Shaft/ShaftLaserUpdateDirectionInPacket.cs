using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Shaft;

public class ShaftLaserUpdateDirectionInPacket : Packet
{

	[Encode(0)]
	public string? ShooterId { get; set; }

	[Encode(1)]
	public float ProjectionOnVerticalAxis { get; set; }

	public const int ID_CONST = -534192254;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
