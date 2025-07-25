namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Flamethrower starting fire (shooter only).
/// </summary>
public class FlamethrowerStartFireIn : Packet
{
	[Encode(0)]
	public string? Shooter { get; set; }

	public const int ID_CONST = 1212381771;
	public override int Id => ID_CONST;
	public override string Description => "Flamethrower start fire (shooter)";
}
