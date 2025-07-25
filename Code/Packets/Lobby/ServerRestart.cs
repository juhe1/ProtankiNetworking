namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Indicates time (in seconds) until server restart
/// </summary>
public class ServerRestart : Packet
{
	[Encode(0)]
	public int Time { get; set; }

	public const int ID_CONST = -1712113407;
	public override int Id => ID_CONST;
	public override string Description => "Indicates time (in seconds) until server restart";
}
