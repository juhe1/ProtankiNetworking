using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battlecreate;

public class BattleCreateFailedServerHaltingInPacket : Packet
{

	public const int ID_CONST = 566338297;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
