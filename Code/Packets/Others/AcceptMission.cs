namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Accept mission
/// </summary>
public class AcceptMission : Packet
{
	[Encode(0)]
	public int MissionId { get; set; }

	public const int ID_CONST = -867767128;
	public override int Id => ID_CONST;
	public override string Description => "Accept mission";
}
