using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Login;

public class LoginFailedInPacket : Packet
{

	public const int ID_CONST = 103812952;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
