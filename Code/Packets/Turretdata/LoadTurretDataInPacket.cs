using System.Text.Json.Nodes;
using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Turretdata;

public class LoadTurretDataInPacket : Packet
{
	[Encode(0)]
	public JsonNode? Json { get; set; }

	public const int ID_CONST = -2124388778;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
