using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Machinegun;

public class MachineGunHitInPacket : Packet
{

	[Encode(0)]
	public string? Shooter { get; set; }

	[Encode(1)]
	public Vector3D? ShootDirection { get; set; }

	[Encode(2)]
	public TargetHit?[]? Targets { get; set; }

	public const int ID_CONST = -891286317;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
