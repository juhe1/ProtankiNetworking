using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Thunder;

public class ThunderShootStaticOutPacket : Packet
{

	[Encode(0)]
	public int Time { get; set; }

	[Encode(1)]
	public Vector3D? HitPoint { get; set; }

	public const int ID_CONST = 1501310158;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
