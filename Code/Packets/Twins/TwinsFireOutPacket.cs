using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Twins;

public class TwinsFireOutPacket : Packet
{

	[Encode(0)]
	public int Time { get; set; }

	[Encode(1)]
	public byte Barrel { get; set; }

	[Encode(2)]
	public int ShotId { get; set; }

	[Encode(3)]
	public Vector3D? ShotDirection { get; set; }

	public const int ID_CONST = 0;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
