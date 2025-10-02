using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for BattleInviteCC, containing a sound notification resource.
/// </summary>
public class LoadBattleInvite : Packet
{
	[Encode(0)]
	public Resource? SoundNotification { get; set; }

	public const int ID_CONST = 834877801;
	public override int Id => ID_CONST;
	public override string Description => "BattleInviteCC packet with sound notification";
}
