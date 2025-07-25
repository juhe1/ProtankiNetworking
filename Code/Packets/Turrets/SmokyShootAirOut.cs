namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Smokey Shoot at Air
/// </summary>
public class SmokyShootAirOut : Packet
{
	[Encode(0)]
	public int ClientTime { get; set; }

	public const int ID_CONST = 1478921140;
	public override int Id => ID_CONST;
	public override string Description => "Smokey Shoot at Air";
}
