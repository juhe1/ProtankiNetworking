using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for setting Isida target.
/// </summary>
public class SetIsidaTargetIn : Packet
{
	[Encode(0)]
	public string? UserId { get; set; }

	[Encode(1)]
	public IsisState? IsisState { get; set; }

	[Encode(2)]
	public TargetHit? Target { get; set; }

	public const int ID_CONST = 2001632000;
	public override int Id => ID_CONST;
	public override string Description => "Set Isida target event";
}
