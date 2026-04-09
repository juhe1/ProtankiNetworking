using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Isida;

public class SetIsidaTargetInPacket : Packet
{

	[Encode(0)]
	public string? Shooter { get; set; }

	[Encode(1)]
	public IsisState? CurrentState { get; set; }

	[Encode(2)]
	public TargetHit? Target { get; set; }

	public const int ID_CONST = 2001632000;
	public override int Id => ID_CONST;
	public override string Description => "No description provided";
}
