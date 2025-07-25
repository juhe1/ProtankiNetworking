

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     A mission was completed and is available to claim
/// </summary>
public class CompletedMission : Packet
{
    public const int ID_CONST = 1579425801;
    public override int Id => ID_CONST;
    public override string Description => "A mission was completed and is available to claim";


}