

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for sending Railgun start charging event.
/// </summary>
public class RailgunStartChargingIn : Packet
{
    [Encode(0)]
    public string? UserId { get; set; }

    public const int ID_CONST = 346830254;
    public override int Id => ID_CONST;
    public override string Description => "Send Railgun start charging event";


}