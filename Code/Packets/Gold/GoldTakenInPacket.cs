using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Gold;

public class GoldTakenInPacket : Packet
{

	[Encode(0)]
	public string? Username { get; set; }

	public const int ID_CONST = 463494974;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
