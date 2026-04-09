using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Twins;

public class TwinsFireDummyOutPacket : Packet
{

	[Encode(0)]
	public int Time { get; set; }

	[Encode(1)]
	public byte Barrel { get; set; }

	public const int ID_CONST = 0;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
