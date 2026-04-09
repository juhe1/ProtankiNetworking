using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Twins;

public class TwinsShootTargetIn : Packet
{

	[Encode(0)]
	public string? Shooter { get; set; }

	[Encode(1)]
	public byte Barrel { get; set; }

	[Encode(2)]
	public Vector3D? ShotDirection { get; set; }

	public const int ID_CONST = -44282936;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
