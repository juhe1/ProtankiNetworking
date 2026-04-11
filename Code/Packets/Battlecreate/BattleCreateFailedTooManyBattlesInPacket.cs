using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battlecreate;

public class BattleCreateFailedTooManyBattlesInPacket : Packet
{

	public const int ID_CONST = -614313838;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
