namespace ProtankiNetworking.Packets.Chat;

/// <summary>
///     Received a system message in the game chat
/// </summary>
public class ReceiveGameSystemChat : Packet
{
	[Encode(0)]
	public string? Message { get; set; }

	public const int ID_CONST = 606668848;
	public override int Id => ID_CONST;
	public override string Description => "Received a system message in the game chat";
}
