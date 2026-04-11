using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Externalentrance;

public class ValidationSuccessInPacket : Packet
{

	public const int ID_CONST = -1179390022;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
