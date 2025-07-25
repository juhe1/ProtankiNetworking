namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Reset Isida target event.
/// </summary>
public class ResetIsidaTargetIn : Packet
{
	[Encode(0)]
	public string? UserId { get; set; }

	public const int ID_CONST = -1271729363;
	public override int Id => ID_CONST;
	public override string Description => "Reset Isida target event";
}
