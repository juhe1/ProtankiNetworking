using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Loginbyhash;

public class LoginByHashFailedInPacket : Packet
{

	public const int ID_CONST = 655372891;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
