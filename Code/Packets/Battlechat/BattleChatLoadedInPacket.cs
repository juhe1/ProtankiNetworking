using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battlechat;

public class BattleChatLoadedInPacket : Packet
{

	public const int ID_CONST = -643105296;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
