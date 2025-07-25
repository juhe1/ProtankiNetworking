namespace ProtankiNetworking.Packets.Status;

/// <summary>
///     Loads the rank of a player
/// </summary>
public class RankStatus : Packet
{
	[Encode(0)]
	public int Rank { get; set; }

	[Encode(1)]
	public string? Username { get; set; }

	public const int ID_CONST = -962759489;
	public override int Id => ID_CONST;
	public override string Description => "Loads the rank of a player";
}
