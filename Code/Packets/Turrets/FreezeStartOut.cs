namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     When we start using Freeze
/// </summary>
public class FreezeStartOut : Packet
{
	[Encode(0)]
	public int ClientTime { get; set; }

	public const int ID_CONST = -75406982;
	public override int Id => ID_CONST;
	public override string Description => "When we start using Freeze";
}
