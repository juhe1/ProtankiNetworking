using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Externalentrance;

public class SetLoginDataOutPacket : Packet
{

	[Encode(0)]
	public bool RememberMe { get; set; }

	public const int ID_CONST = -1967950183;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
