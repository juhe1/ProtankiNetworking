

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Flamethrower stopping fire (shooter only).
/// </summary>
public class FlamethrowerStopFireIn : Packet
{
    [Encode(0)]
    public string? Shooter { get; set; }

    public const int ID_CONST = 1333088437;
    public override int Id => ID_CONST;
    public override string Description => "Flamethrower stop fire (shooter)";


}