namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Thunder fire (time).
/// </summary>
public class ThunderFireOut : Packet
{
	[Encode(0)]
	public int Time { get; set; }

	public const int ID_CONST = -136344740;
	public override int Id => ID_CONST;
	public override string Description => "Thunder fire (time)";
}
