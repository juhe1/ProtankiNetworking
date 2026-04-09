using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Usernotifier;

public class PremiumStatusInPacket : Packet
{

	[Encode(0)]
	public PremiumNotifierData? PremiumData { get; set; }

	public const int ID_CONST = -2069508071;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
