using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Tank;

public class PrepareToSpawnInPacket : Packet
{

	[Encode(0)]
	public Vector3D? Position { get; set; }

	[Encode(1)]
	public Vector3D? Orientation { get; set; }

	public const int ID_CONST = -157204477;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
