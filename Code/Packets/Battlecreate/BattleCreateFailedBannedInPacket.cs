using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battlecreate;

public class BattleCreateFailedBannedInPacket : Packet
{

	public const int ID_CONST = -1491503394;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
