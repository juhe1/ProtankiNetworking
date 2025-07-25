

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for gold box taken event (uid).
/// </summary>
public class GoldTaken : Packet
{
    [Encode(0)]
    public string? Uid { get; set; }

    public const int ID_CONST = 463494974;
    public override int Id => ID_CONST;
    public override string Description => "Gold taken (uid)";


}