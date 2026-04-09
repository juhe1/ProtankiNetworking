using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Smoky;

public class SmokyFireStaticOutPacket : Packet
{

	[Encode(0)]
	public int Time { get; set; }

	[Encode(1)]
	public Vector3D? HitPoint { get; set; }

	public const int ID_CONST = 1470597926;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
