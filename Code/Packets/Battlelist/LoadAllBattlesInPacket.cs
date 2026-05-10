using System.Text.Json.Nodes;
using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battlelist;

public class LoadAllBattlesInPacket : Packet
{
	[Encode(0)]
	public JsonNode? BattlesJson { get; set; }

	public const int ID_CONST = 552006706;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
