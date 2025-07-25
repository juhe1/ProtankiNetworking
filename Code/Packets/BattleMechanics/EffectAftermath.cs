

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Effect Aftermath
/// </summary>
public class EffectAftermath : Packet
{
    [Encode(0)]
    public string? Username { get; set; }

    [Encode(1)]
    public int EffectId { get; set; }

    [Encode(2)]
    public int Duration { get; set; }

    [Encode(3)]
    public bool ActiveAfterDeath { get; set; }

    [Encode(4)]
    public byte EffectLevel { get; set; }

    public const int ID_CONST = -1639713644;
    public override int Id => ID_CONST;
    public override string Description => "Effect Aftermath";


}