using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Ricochet;

public class RicochetFireDummyOutPacket : Packet
{

	[Encode(0)]
	public int Time { get; set; }

	public const int ID_CONST = 1147113344;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
