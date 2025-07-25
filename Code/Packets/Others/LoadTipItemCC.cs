

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Loads a tip item for loader window.
/// </summary>
public class LoadTipItemCC : Packet
{
    [Encode(0)]
    public int Preview { get; set; }

    public const int ID_CONST = 2094741924;
    public override int Id => ID_CONST;
    public override string Description => "Load a tip item for loader window.";


}