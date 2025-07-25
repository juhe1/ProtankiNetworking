

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Sends a self destruct request to the server
/// </summary>
public class SelfDestruct : Packet
{
    public const int ID_CONST = 988664577;
    public override int Id => ID_CONST;
    public override string Description => "Sends a self destruct request to the server";


}