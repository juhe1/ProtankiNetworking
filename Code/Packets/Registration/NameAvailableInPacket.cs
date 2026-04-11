using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Registration;

public class NameAvailableInPacket : Packet
{

	public const int ID_CONST = -706679202;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
