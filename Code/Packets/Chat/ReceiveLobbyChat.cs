using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Chat;

/// <summary>
///     Receives chat messages from the lobby
/// </summary>
public class ReceiveLobbyChat : Packet
{
	[Encode(0)]
	public ChatMessage?[]? Messages { get; set; }

	public const int ID_CONST = -1263520410;
	public override int Id => ID_CONST;
	public override string Description => "Receives chat messages from the lobby";
}
