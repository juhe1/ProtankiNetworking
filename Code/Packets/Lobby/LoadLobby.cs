namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Load battle info
/// </summary>
public class LoadLobby : Packet
{
	public const int ID_CONST = 1452181070;
	public override int Id => ID_CONST;
	public override string Description => "Load battle info";
}
