using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Tank;

public class UnloadTankInPacket : Packet
{

	[Encode(0)]
	public string? TankId { get; set; }

	public const int ID_CONST = 1719707347;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
