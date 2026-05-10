using System.Text.Json.Nodes;
using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Inventory;

public class LoadInventoryInPacket : Packet
{
	[Encode(0)]
	public JsonNode? BattlesJson { get; set; }

	public const int ID_CONST = -137249251;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
