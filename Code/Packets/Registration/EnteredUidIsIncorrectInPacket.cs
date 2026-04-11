using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Registration;

public class EnteredUidIsIncorrectInPacket : Packet
{

	public const int ID_CONST = 1480924803;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
