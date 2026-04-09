using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battlestatistics;

public class RoundStartInPacket : Packet
{

	[Encode(0)]
	public int TimeLimitInSec { get; set; }

	public const int ID_CONST = 732434644;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
