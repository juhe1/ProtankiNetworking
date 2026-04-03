namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
/// This is sent to server when client confirms that it wants to spawn.
/// </summary>
public class RespawnConfirm : Packet
{
	public const int ID_CONST = -1378839846;
	public override int Id => ID_CONST;
	public override string Description =>
		"This is sent to server when client confirms that it wants to spawn.";
}
