using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Freeze;

public class FreezeDamageOutPacket : Packet
{

	[Encode(0)]
	public int ClientTime { get; set; }

	[Encode(1)]
	public string?[]? Targets { get; set; }

	[Encode(2)]
	public short[]? IncarnationIDs { get; set; }

	[Encode(3)]
	public Vector3D?[]? Positions { get; set; }

	[Encode(4)]
	public Vector3D?[]? TargetHitPointsGlobal { get; set; }

	public const int ID_CONST = -2123941185;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
