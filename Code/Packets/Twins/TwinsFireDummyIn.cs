using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Twins;

public class TwinsFireDummyIn : Packet
{

	[Encode(0)]
	public string? Shooter { get; set; }

	[Encode(1)]
	public byte Barrel { get; set; }

	public const int ID_CONST = -328554480;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
