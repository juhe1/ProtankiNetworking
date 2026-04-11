using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Externalentrance;

public class ValidationFailedInPacket : Packet
{

	public const int ID_CONST = -570114058;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
