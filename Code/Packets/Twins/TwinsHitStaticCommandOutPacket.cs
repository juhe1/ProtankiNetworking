using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Twins;

public class TwinsHitStaticCommandOutPacket : Packet
{

	[Encode(0)]
	public int Time { get; set; }

	[Encode(1)]
	public int ShotId { get; set; }

	[Encode(2)]
	public Vector3D? HitPointWorld { get; set; }

	public const int ID_CONST = -482023661;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
