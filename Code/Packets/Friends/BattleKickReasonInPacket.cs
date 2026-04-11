using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Friends;

public class BattleKickReasonInPacket : Packet
{

	public const int ID_CONST = 1441234714;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
