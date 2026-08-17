using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.BlockValidator;

public class YouWereKickedInPacket : Packet
{

	[Encode(0)]
	public string? Reason { get; set; }

	[Encode(1)]
	public int Minutes { get; set; }

	[Encode(2)]
	public int Hours { get; set; }

	[Encode(3)]
	public int Days { get; set; }

	public const int ID_CONST = 1200280053;
	public override int Id => ID_CONST;
	public override string Description => "Informs the client that the user has been kicked and provides the reason and ban duration.";
}
