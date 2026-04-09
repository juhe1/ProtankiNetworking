using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Usernotifier;

public class OnlineStatusInPacket : Packet
{

	[Encode(0)]
	public OnlineNotifierData? UserInfo { get; set; }

	public const int ID_CONST = 2041598093;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
