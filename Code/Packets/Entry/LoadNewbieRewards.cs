namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Tells the client which beginner rewards the player has yet to complete
/// </summary>
public class LoadNewbieRewards : Packet
{
	[Encode(0)]
	public int[]? IncompleteRewards { get; set; }

	public const int ID_CONST = 602656160;
	public override int Id => ID_CONST;
	public override string Description =>
		"Tells the client which beginner rewards the player has yet to complete";
}
