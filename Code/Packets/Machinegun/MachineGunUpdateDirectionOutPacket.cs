using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Machinegun;

public class MachineGunUpdateDirectionOutPacket : Packet
{

	[Encode(0)]
	public int Time { get; set; }

	[Encode(1)]
	public Vector3D? ShootDirection { get; set; }

	public const int ID_CONST = 299028276;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
