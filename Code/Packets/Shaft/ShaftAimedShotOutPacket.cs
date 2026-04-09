using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Shaft;

public class ShaftAimedShotOutPacket : Packet
{

	[Encode(0)]
	public int ClientTime { get; set; }

	[Encode(1)]
	public Vector3D? StaticHitPoint { get; set; }

	[Encode(2)]
	public string?[]? Targets { get; set; }

	[Encode(3)]
	public Vector3D?[]? TargetHitPoints { get; set; }

	[Encode(4)]
	public short[]? TargetIncarnation { get; set; }

	[Encode(5)]
	public Vector3D?[]? TargetBodyPositions { get; set; }

	[Encode(6)]
	public Vector3D?[]? TargetHitPointsGlobal { get; set; }

	public const int ID_CONST = 1632423559;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
