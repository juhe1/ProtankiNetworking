using System.Text.Json.Nodes;
using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Init;

public class LoadResourcesInPacket : Packet
{
	[Encode(0)]
	public JsonNode? ResourcesJson { get; set; }

	[Encode(1)]
	public int CallbackId { get; set; }

	public const int ID_CONST = -1797047325;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
