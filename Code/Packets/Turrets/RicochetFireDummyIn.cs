

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Ricochet fire dummy event (shooter only).
/// </summary>
public class RicochetFireDummyIn : Packet
{
    [Encode(0)]
    public string? Shooter { get; set; }

    public const int ID_CONST = -1670466290;
    public override int Id => ID_CONST;
    public override string Description => "Ricochet fire dummy event (shooter)";


}