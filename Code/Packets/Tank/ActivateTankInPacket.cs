using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Tank;

public class ActivateTankInPacket : Packet
{

	[Encode(0)]
	public string? TankId { get; set; }

	public const int ID_CONST = 1868573511;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
