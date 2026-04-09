using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Externalentrance;

public class LoadExternalEntranceInPacket : Packet
{

	[Encode(0)]
	public SocialNetworkEntranceParams?[]? SocialNetworkEntranceParams { get; set; }

	public const int ID_CONST = -1715719586;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
