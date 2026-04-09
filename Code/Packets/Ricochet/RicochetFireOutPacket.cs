using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Ricochet;

public class RicochetFireOutPacket : Packet
{

	[Encode(0)]
	public int Time { get; set; }

	[Encode(1)]
	public int ShotId { get; set; }

	[Encode(2)]
	public short ShotDirectionX { get; set; }

	[Encode(3)]
	public short ShotDirectionY { get; set; }

	[Encode(4)]
	public short ShotDirectionZ { get; set; }

	public const int ID_CONST = -1907971330;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
