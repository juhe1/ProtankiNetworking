using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Battlemine;

public class PutMineInPacket : Packet
{

	[Encode(0)]
	public string? MineId { get; set; }

	[Encode(1)]
	public float X { get; set; }

	[Encode(2)]
	public float Y { get; set; }

	[Encode(3)]
	public float Z { get; set; }

	[Encode(4)]
	public string? UserId { get; set; }

	public const int ID_CONST = 272183855;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
