

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for mine explosion event (mineId, targetId).
/// </summary>
public class ExplodeMine : Packet
{
    [Encode(0)]
    public string? MineId { get; set; }

    [Encode(1)]
    public string? TargetId { get; set; }

    public const int ID_CONST = 1387974401;
    public override int Id => ID_CONST;
    public override string Description => "Explode mine (mineId, targetId)";


}