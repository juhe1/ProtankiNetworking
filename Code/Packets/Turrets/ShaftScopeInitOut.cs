namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Initiates a shaft scope shot
/// </summary>
public class ShaftScopeInitOut : Packet
{
	[Encode(0)]
	public int ClientTime { get; set; }

	public const int ID_CONST = -367760678;
	public override int Id => ID_CONST;
	public override string Description => "Initiates a shaft scope shot";
}
