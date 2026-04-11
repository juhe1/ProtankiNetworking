using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Login;

public class LoginSuccessInPacket : Packet
{

	public const int ID_CONST = -1923286328;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
