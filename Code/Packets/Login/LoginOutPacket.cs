using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Login;

public class LoginOutPacket : Packet
{

	[Encode(0)]
	public string? Username { get; set; }

	[Encode(1)]
	public string? Password { get; set; }

	[Encode(2)]
	public bool RememberMe { get; set; }

	public const int ID_CONST = -739684591;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
