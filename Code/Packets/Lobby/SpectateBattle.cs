namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Client requests to spectate the selected battle
/// </summary>
public class SpectateBattle : Packet
{
	public const int ID_CONST = -1315002220;
	public override int Id => ID_CONST;
	public override string Description => "Client requests to spectate the selected battle";
}
