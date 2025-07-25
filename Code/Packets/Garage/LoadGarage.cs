namespace ProtankiNetworking.Packets.Garage;

/// <summary>
///     Load garage
/// </summary>
public class LoadGarage : Packet
{
	public const int ID_CONST = -479046431;
	public override int Id => ID_CONST;
	public override string Description => "Load garage";
}
