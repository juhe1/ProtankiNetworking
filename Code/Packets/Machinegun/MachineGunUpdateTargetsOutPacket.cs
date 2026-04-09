using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Machinegun;

public class MachineGunUpdateTargetsOutPacket : Packet
{

	[Encode(0)]
	public int Time { get; set; }

	[Encode(1)]
	public Vector3D? ShootDirection { get; set; }

	[Encode(2)]
	public TargetPosition?[]? Targets { get; set; }

	public const int ID_CONST = -1889502569;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
