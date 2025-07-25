using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Status;

/// <summary>
///     Sets the battle status of the player to the battle ID
/// </summary>
public class InBattleStatus : Packet
{
	[Encode(0)]
	public BattleNotifier? BattleNotifier { get; set; }

	public const int ID_CONST = -1895446889;
	public override int Id => ID_CONST;
	public override string Description => "Sets the battle status of the player to the battle ID";
}
