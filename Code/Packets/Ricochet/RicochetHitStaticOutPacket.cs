using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Ricochet;

public class RicochetHitStaticOutPacket : Packet
{

	[Encode(0)]
	public int Time { get; set; }

	[Encode(1)]
	public int ShotId { get; set; }

	[Encode(2)]
	public Vector3D?[]? ImpactPoints { get; set; }

	public const int ID_CONST = -1823935471;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
