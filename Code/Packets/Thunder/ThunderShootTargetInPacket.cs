using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Thunder;

public class ThunderShootTargetInPacket : Packet
{

	[Encode(0)]
	public string? Shooter { get; set; }

	[Encode(1)]
	public string? Target { get; set; }

	[Encode(2)]
	public Vector3D? RelativeHitPoint { get; set; }

	public const int ID_CONST = -190359403;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
