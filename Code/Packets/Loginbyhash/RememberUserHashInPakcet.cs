using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Loginbyhash;

public class RememberUserHashInPakcet : Packet
{

	[Encode(0)]
	public string? UserHash { get; set; }

	public const int ID_CONST = 932564569;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
