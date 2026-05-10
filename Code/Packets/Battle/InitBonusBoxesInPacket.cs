using System.Text.Json.Nodes;
using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battle;

public class InitBonusBoxesInPacket : Packet
{
	[Encode(0)]
	public JsonNode? Json { get; set; }

	public const int ID_CONST = 228171466;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
