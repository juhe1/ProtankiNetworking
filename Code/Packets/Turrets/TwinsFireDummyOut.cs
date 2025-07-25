namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for fire dummy command out (time, barrel).
/// </summary>
public class TwinsFireDummyOut : Packet
{
	[Encode(0)]
	public int Time { get; set; }

	[Encode(1)]
	public byte Barrel { get; set; }

	public const int ID_CONST = -1805942142;
	public override int Id => ID_CONST;
	public override string Description => "Fire dummy command out (time, barrel).";
}
