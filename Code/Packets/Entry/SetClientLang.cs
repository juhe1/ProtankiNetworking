namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Sets client language
/// </summary>
public class SetClientLang : Packet
{
	[Encode(0)]
	public string? Lang { get; set; }

	public const int ID_CONST = -1864333717;
	public override int Id => ID_CONST;
	public override string Description => "Sets client language";
}
