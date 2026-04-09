using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battlecreate;

public class CreateBattleOutPacket : Packet
{

	[Encode(0)]
	public BattleCreateParameters? BattleCreateParameters { get; set; }

	public const int ID_CONST = 0;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
