namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet to unload the lobby chat.
/// </summary>
public class UnloadLobbyChat : Packet
{
	public const int ID_CONST = -920985123;
	public override int Id => ID_CONST;
	public override string Description => "Unload the lobby chat";
}
