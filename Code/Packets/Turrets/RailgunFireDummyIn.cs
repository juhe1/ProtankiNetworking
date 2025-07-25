

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for Railgun fire dummy in (shooter).
/// </summary>
public class RailgunFireDummyIn : Packet
{
    [Encode(0)]
    public string? Shooter { get; set; }

    public const int ID_CONST = 1459211021;
    public override int Id => ID_CONST;
    public override string Description => "Railgun fire dummy in (shooter)";


}