using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Smoky;

public class SmokyFireOutPacket : Packet
{

	[Encode(0)]
	public int Time { get; set; }

	public const int ID_CONST = 1478921140;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
