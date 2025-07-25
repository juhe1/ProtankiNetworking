

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Change mission
/// </summary>
public class ChangeMission : Packet
{
    [Encode(0)]
    public int MissionId { get; set; }

    public const int ID_CONST = 1642608662;
    public override int Id => ID_CONST;
    public override string Description => "Change mission";


}