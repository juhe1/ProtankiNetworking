using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for loading the social network panel (passwordCreated, socialNetworkParams)
/// </summary>
public class LoadSocialNetworkPanelCC : Packet
{
	[Encode(0)]
	public bool PasswordCreated { get; set; }

	[Encode(1)]
	public SocialNetworkPanelParams?[]? SocialNetworkParams { get; set; }

	public const int ID_CONST = -583564465;
	public override int Id => ID_CONST;
	public override string Description =>
		"Load social network panel (passwordCreated, socialNetworkParams)";
}
