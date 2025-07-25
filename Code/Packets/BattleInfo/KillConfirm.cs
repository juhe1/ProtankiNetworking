namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     A tank has been killed
/// </summary>
public class KillConfirm : Packet
{
	[Encode(0)]
	public string? Target { get; set; }

	[Encode(1)]
	public string? Killer { get; set; }

	[Encode(2)]
	public int RespDelay { get; set; }

	public const int ID_CONST = -42520728;
	public override int Id => ID_CONST;
	public override string Description => "A tank has been killed";
}
