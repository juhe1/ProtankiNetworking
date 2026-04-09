using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Shotgun;

public class ShotgunShootInPacket : Packet
{

	[Encode(0)]
	public string? Shooter { get; set; }

	[Encode(1)]
	public Vector3D? ShootDirection { get; set; }

	[Encode(2)]
	public TargetHit?[]? Targets { get; set; }

	public const int ID_CONST = 471157826;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
