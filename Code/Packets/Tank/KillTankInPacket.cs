using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Tank;

public class KillTankInPacket : Packet
{

	[Encode(0)]
	public string? TankId { get; set; }

	[Encode(1)]
	public string? Killer { get; set; }

	[Encode(2)]
	public int Delay { get; set; }

	public const int ID_CONST = -42520728;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
