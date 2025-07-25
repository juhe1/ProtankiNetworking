using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for returning a flag to base, specifying the team and tank.
/// </summary>
public class ReturnFlagToBase : Packet
{
    [Encode(0)]
    public BattleTeam? FlagTeam { get; set; }

    [Encode(1)]
    public string? Tank { get; set; }

    public const int ID_CONST = -1026428589;
    public override int Id => ID_CONST;
    public override string Description => "Return flag to base (team and tank)";


}