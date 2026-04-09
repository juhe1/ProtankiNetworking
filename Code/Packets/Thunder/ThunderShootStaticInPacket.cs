using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Thunder;

public class ThunderShootStaticInPacket : Packet
{

	[Encode(0)]
	public string? Shooter { get; set; }

	[Encode(1)]
	public Vector3D? HitPoint { get; set; }

	public const int ID_CONST = 1690491826;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
