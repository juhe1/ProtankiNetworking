using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Machinegun;

public class MachineGunStartFireOutPacket : Packet
{

	[Encode(0)]
	public int Time { get; set; }

	public const int ID_CONST = -520655432;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
