namespace ProtankiNetworking.Packets.Chat;

/// <summary>
///     Sends a chat message to the lobby
/// </summary>
public class SendLobbyChat : Packet
{
	[Encode(0)]
	public string? Username { get; set; }

	[Encode(1)]
	public string? Message { get; set; }

	public const int ID_CONST = 705454610;
	public override int Id => ID_CONST;
	public override string Description => "Sends a chat message to the lobby";
}
