using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Externalentrance;

public class LinkAlreadyExistsInPacket : Packet
{

	public const int ID_CONST = 0;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
