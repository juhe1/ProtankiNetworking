using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Tank;

public class SetTankTemperatureInPacket : Packet
{

	[Encode(0)]
	public string? TankId { get; set; }

	[Encode(1)]
	public float Temperature { get; set; }

	public const int ID_CONST = 581377054;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
