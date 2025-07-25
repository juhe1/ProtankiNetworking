

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Client end the Fantom period to fully spawn
/// </summary>
public class EndRespFantom : Packet
{
    public const int ID_CONST = 1178028365;
    public override int Id => ID_CONST;
    public override string Description => "Client end the Fantom period to fully spawn";


}