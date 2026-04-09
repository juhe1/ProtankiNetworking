using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Tank;

public class SetTankHealthInPacket : Packet
{

	[Encode(0)]
	public string? TankId { get; set; }

	[Encode(1)]
	public float Health { get; set; }

	public const int ID_CONST = -611961116;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
