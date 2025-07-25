namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Packet for unloading battle objects.
/// </summary>
public class UnloadBattleObjects : Packet
{
	public const int ID_CONST = -985579124;
	public override int Id => ID_CONST;
	public override string Description => "Unload battle objects";
}
