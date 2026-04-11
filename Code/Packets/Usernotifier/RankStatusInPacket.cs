using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Usernotifier;

public class RankStatusInPacket : Packet
{

	[Encode(0)]
	public RankNotifierData? UserInfo { get; set; }

	public const int ID_CONST = -962759489;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
