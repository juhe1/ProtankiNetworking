

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Shaft laser hide out (no attributes).
/// </summary>
public class ShaftLaserHideOut : Packet
{
    public const int ID_CONST = 843751647;
    public override int Id => ID_CONST;
    public override string Description => "Shaft laser hide out (no attributes)";
}