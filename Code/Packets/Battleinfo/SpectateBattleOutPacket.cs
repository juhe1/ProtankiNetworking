using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battleinfo;

public class SpectateBattleOutPacket : Packet
{

	public const int ID_CONST = -1315002220;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
