namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet to unload the battle select space.
/// </summary>
public class UnloadBattleSelectSpace : Packet
{
	public const int ID_CONST = -324155151;
	public override int Id => ID_CONST;
	public override string Description => "Unload the battle select space";
}
