using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Machinegun;

public class MachineGunStopFireInPacket : Packet
{

	[Encode(0)]
	public string? Shooter { get; set; }

	public const int ID_CONST = 133452238;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
