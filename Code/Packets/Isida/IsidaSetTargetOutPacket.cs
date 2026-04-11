using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Isida;

public class IsidaSetTargetOutPacket : Packet
{

	[Encode(0)]
	public int ClientTime { get; set; }

	[Encode(1)]
	public string? Target { get; set; }

	[Encode(2)]
	public short Incarnation { get; set; }

	[Encode(3)]
	public Vector3D? LocalHitPoint { get; set; }

	public const int ID_CONST = 381067984;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
