using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Machinegun;

public class MachineGunStopFireOutPacket : Packet
{

	[Encode(0)]
	public int Time { get; set; }

	public const int ID_CONST = 1794372798;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
