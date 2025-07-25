

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for activating manual targeting in Shaft turret (shooter only).
/// </summary>
public class ShaftActivateManualTargetingIn : Packet
{
    [Encode(0)]
    public string? Shooter { get; set; }

    public const int ID_CONST = -1222085753;
    public override int Id => ID_CONST;
    public override string Description => "Shaft activate manual targeting (shooter)";


}