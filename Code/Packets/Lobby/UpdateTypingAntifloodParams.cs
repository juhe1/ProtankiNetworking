namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for updating typing antiflood parameters.
/// </summary>
public class UpdateTypingAntifloodParams : Packet
{
	[Encode(0)]
	public int SymbolCost { get; set; }

	[Encode(1)]
	public int MessageCost { get; set; }

	public const int ID_CONST = 744948472;
	public override int Id => ID_CONST;
	public override string Description => "Update typing antiflood parameters";
}
