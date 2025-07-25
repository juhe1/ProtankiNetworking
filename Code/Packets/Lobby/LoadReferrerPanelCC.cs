namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for loading referrer panel configuration (ReferrerPanelCC).
/// </summary>
public class LoadReferrerPanelCC : Packet
{
	[Encode(0)]
	public string? Hash { get; set; }

	[Encode(1)]
	public string? Host { get; set; }

	public const int ID_CONST = 832270655;
	public override int Id => ID_CONST;
	public override string Description => "Load referrer panel configuration (ReferrerPanelCC)";
}
