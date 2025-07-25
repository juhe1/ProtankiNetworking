namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for stopping Isida action.
/// </summary>
public class StopIsidaIn : Packet
{
	[Encode(0)]
	public string? UserId { get; set; }

	public const int ID_CONST = 981035905;
	public override int Id => ID_CONST;
	public override string Description => "Stop Isida action event";
}
