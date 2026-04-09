using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Machinegun;

public class MachineGunStartFireInPacket : Packet
{

	[Encode(0)]
	public string? Shooter { get; set; }

	public const int ID_CONST = -1616602030;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
