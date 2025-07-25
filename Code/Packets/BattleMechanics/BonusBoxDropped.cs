using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     A bonus box has dropped
/// </summary>
public class BonusBoxDropped : Packet
{
    [Encode(0)]
    public string? BonusId { get; set; }

    [Encode(1)]
    public Vector3D? Position { get; set; }

    [Encode(2)]
    public int FallTimeThreshold { get; set; }

    public const int ID_CONST = 1831462385;
    public override int Id => ID_CONST;
    public override string Description => "A bonus box has dropped";


}