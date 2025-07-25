

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Change free mission
/// </summary>
public class ChangeFreeMission : Packet
{
    [Encode(0)]
    public int MissionId { get; set; }

    public const int ID_CONST = 326032325;
    public override int Id => ID_CONST;
    public override string Description => "Change free mission";


}