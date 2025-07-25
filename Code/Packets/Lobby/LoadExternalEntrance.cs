using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Loads external entrance data, containing a vector of social network entrance params.
/// </summary>
public class LoadExternalEntrance : Packet
{
	[Encode(0)]
	public SocialNetworkEntranceParams?[]? SocialNetworkEntranceParams { get; set; }

	public const int ID_CONST = -1715719586;
	public override int Id => ID_CONST;
	public override string Description => "Load external entrance data.";
}
