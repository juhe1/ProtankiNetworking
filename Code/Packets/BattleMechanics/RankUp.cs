namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Player Ranked Up
/// </summary>
public class RankUp : Packet
{
	[Encode(0)]
	public string? Username { get; set; }

	[Encode(1)]
	public int Rank { get; set; }

	public const int ID_CONST = 1262947513;
	public override int Id => ID_CONST;
	public override string Description => "Player Ranked Up";
}
