using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     A new player has joined the team battle
/// </summary>
public class LoadNewPlayerTeam : Packet
{
	[Encode(0)]
	public string? Username { get; set; }

	[Encode(1)]
	public BattleUser?[]? Userinfos { get; set; }

	[Encode(2)]
	public int Team { get; set; }

	public const int ID_CONST = 2040021062;
	public override int Id => ID_CONST;
	public override string Description => "A new player has joined the team battle";
}
