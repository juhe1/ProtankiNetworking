using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battlelist;

public class UnloadBattleSelectSpaceInPacket : Packet
{

	public const int ID_CONST = -324155151;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
