using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battlemine;

public class LoadBattleMinesCCInPacket : Packet
{

	[Encode(0)]
	public BattleMineCC? Cc { get; set; }

	public const int ID_CONST = -226978906;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
