using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Isida;

public class IsidaStopOutPacket : Packet
{

	[Encode(0)]
	public int ClientTime { get; set; }

	public const int ID_CONST = -1051248475;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
