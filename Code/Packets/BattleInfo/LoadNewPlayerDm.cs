using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     A new player has joined the battle
/// </summary>
public class LoadNewPlayerDm : Packet
{
	[Encode(0)]
	public string? Username { get; set; }

	[Encode(1)]
	public BattleUser?[]? Userinfos { get; set; }

	public const int ID_CONST = 862913394;
	public override int Id => ID_CONST;
	public override string Description => "A new player has joined the battle";
}
