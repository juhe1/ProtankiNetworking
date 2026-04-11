using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battle;

public class UnloadBattleSpaceInPacket : Packet
{

	public const int ID_CONST = -985579124;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
