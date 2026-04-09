using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Thunder;

public class ThunderShootOutPacket : Packet
{

	[Encode(0)]
	public int Time { get; set; }

	public const int ID_CONST = -136344740;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
