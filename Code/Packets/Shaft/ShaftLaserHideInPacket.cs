using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Shaft;

public class ShaftLaserHideInPacket : Packet
{

	[Encode(0)]
	public string? ShooterId { get; set; }

	public const int ID_CONST = -380595194;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
