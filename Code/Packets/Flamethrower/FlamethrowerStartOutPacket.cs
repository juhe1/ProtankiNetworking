using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Flamethrower;

public class FlamethrowerStartOutPacket : Packet
{

	[Encode(0)]
	public int ClientTime { get; set; }

	public const int ID_CONST = -1986638927;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
