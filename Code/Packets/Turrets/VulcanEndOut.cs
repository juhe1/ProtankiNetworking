

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Vulcan stops shooting
/// </summary>
public class VulcanEndOut : Packet
{
    [Encode(0)]
    public int ClientTime { get; set; }

    public const int ID_CONST = 1794372798;
    public override int Id => ID_CONST;
    public override string Description => "Vulcan stops shooting";


}