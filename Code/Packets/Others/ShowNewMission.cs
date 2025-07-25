using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Show the new mission that was previously changed
/// </summary>
public class ShowNewMission : Packet
{
    [Encode(0)]
    public int MissionId { get; set; }

    [Encode(1)]
    public Mission? Mission { get; set; }

    public const int ID_CONST = -1266665816;
    public override int Id => ID_CONST;
    public override string Description => "Show the new mission that was previously changed";


}