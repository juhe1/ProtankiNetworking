namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Firebird starts shooting
/// </summary>
public class FlamethrowerStartOut : Packet
{
	[Encode(0)]
	public int ClientTime { get; set; }

	public const int ID_CONST = -1986638927;
	public override int Id => ID_CONST;
	public override string Description => "Firebird starts shooting";
}
