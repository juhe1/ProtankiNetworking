using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battle;

public class InitBattleInPacket : Packet
{

	[Encode(0)]
	public string? Json { get; set; }

	public const int ID_CONST = -152638117;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
