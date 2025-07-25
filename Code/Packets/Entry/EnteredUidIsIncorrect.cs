namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Packet indicating that the entered UID is incorrect.
/// </summary>
public class EnteredUidIsIncorrect : Packet
{
	public static int IdStatic { get; } = 1480924803;
	public override int Id => IdStatic;
	public override string Description => "Entered UID is incorrect";
}
