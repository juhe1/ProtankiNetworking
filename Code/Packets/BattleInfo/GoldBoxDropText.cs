namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Announces that a gold box will drop soon
/// </summary>
public class GoldBoxDropText : Packet
{
	[Encode(0)]
	public string? Text { get; set; }

	[Encode(1)]
	public int SoundID { get; set; }

	public const int ID_CONST = -666893269;
	public override int Id => ID_CONST;
	public override string Description => "Announces that a gold box will drop soon";
}
