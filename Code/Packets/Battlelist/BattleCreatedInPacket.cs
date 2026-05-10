using System.Text.Json.Nodes;
using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battlelist;

public class BattleCreatedInPacket : Packet
{
	[Encode(0)]
	public JsonNode? BattlesJson { get; set; }

	public const int ID_CONST = 802300608;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
