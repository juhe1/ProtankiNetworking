namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Player Rating stats
/// </summary>
public class LoadRatingStats : Packet
{
	[Encode(0)]
	public float Rating { get; set; }

	[Encode(1)]
	public int Place { get; set; }

	public const int ID_CONST = -1128606444;
	public override int Id => ID_CONST;
	public override string Description => "Player Rating stats";
}
