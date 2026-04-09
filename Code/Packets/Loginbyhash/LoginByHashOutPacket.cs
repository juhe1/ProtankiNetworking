using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Loginbyhash;

public class LoginByHashOutPacket : Packet
{

	[Encode(0)]
	public string? Hash { get; set; }

	public const int ID_CONST = -845588810;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
