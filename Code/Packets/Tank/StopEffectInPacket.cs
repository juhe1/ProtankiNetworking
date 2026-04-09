using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Tank;

public class StopEffectInPacket : Packet
{

	[Encode(0)]
	public string? TankId { get; set; }

	[Encode(1)]
	public int EffectId { get; set; }

	public const int ID_CONST = -1994318624;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
