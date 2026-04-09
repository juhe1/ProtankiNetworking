using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Smoky;

public class SmokyFireTargetOutPacket : Packet
{

	[Encode(0)]
	public int Time { get; set; }

	[Encode(1)]
	public string? Target { get; set; }

	[Encode(2)]
	public short Incarnation { get; set; }

	[Encode(3)]
	public Vector3D? TargetPosition { get; set; }

	[Encode(4)]
	public Vector3D? HitPoint { get; set; }

	[Encode(5)]
	public Vector3D? HitPointWorld { get; set; }

	public const int ID_CONST = 229267683;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
