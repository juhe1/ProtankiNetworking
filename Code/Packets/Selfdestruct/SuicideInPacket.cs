using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Selfdestruct;

public class SuicideInPacket : Packet
{

	[Encode(0)]
	public string? TankId { get; set; }

	[Encode(1)]
	public int Delay { get; set; }

	public const int ID_CONST = 162656882;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
