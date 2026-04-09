using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Thunder;

public class ThunderShootTargetOutPacket : Packet
{

	[Encode(0)]
	public int Time { get; set; }

	[Encode(1)]
	public Vector3D? RelativeHitPoint { get; set; }

	[Encode(2)]
	public string? Target { get; set; }

	[Encode(3)]
	public short Incarnation { get; set; }

	[Encode(4)]
	public Vector3D? TargetPosition { get; set; }

	[Encode(5)]
	public Vector3D? HitPointWorld { get; set; }

	public const int ID_CONST = 259979915;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
