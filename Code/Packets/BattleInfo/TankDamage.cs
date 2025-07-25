using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Damage dealt to a tank
/// </summary>
public class TankDamage : Packet
{
	[Encode(0)]
	public TankDamageData?[]? Damages { get; set; }

	public const int ID_CONST = -1165230470;
	public override int Id => ID_CONST;
	public override string Description => "Damage dealt to a tank";
}
