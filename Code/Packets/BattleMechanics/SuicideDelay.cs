

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Suicide delay packet
/// </summary>
public class SuicideDelay : Packet
{
    [Encode(0)]
    public int SuicideDelayMS { get; set; }

    public const int ID_CONST = -911983090;
    public override int Id => ID_CONST;
    public override string Description => "Suicide delay packet";


}