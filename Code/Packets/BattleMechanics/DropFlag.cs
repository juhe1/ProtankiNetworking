using ProtankiNetworking.EncodableData;
using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for dropping a flag at a position for a team.
/// </summary>
public class DropFlag : Packet
{
    [Encode(0)]
    public Vector3D? Position { get; set; }

    [Encode(1)]
    public BattleTeam? FlagTeam { get; set; }

    public const int ID_CONST = 1925237062;
    public override int Id => ID_CONST;
    public override string Description => "Drop flag at position for a team";


}