using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battlecreate;

public class BattleCreateFailedDisabledInPacket : Packet
{

	public const int ID_CONST = 947161947;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
