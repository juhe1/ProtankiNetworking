using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Ricochet;

public class RicochetFireDummyInPacket : Packet
{

	[Encode(0)]
	public string? Shooter { get; set; }

	public const int ID_CONST = -1670466290;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
