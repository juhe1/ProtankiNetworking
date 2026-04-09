using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battlestatistics;

public class BattleFundInPacket : Packet
{

	[Encode(0)]
	public int Fund { get; set; }

	public const int ID_CONST = 1149211509;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
