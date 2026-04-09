using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Ricochet;

public class RicochetHitTargetOutPacket : Packet
{

	[Encode(0)]
	public int Time { get; set; }

	[Encode(1)]
	public string? Target { get; set; }

	[Encode(2)]
	public int ShotId { get; set; }

	[Encode(3)]
	public Vector3D? TargetPosition { get; set; }

	[Encode(4)]
	public Vector3D?[]? ImpactPoints { get; set; }

	public const int ID_CONST = 1229701582;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
