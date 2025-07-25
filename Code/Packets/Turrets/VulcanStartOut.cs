

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Vulcan starts shooting
/// </summary>
public class VulcanStartOut : Packet
{
    [Encode(0)]
    public int ClientTime { get; set; }

    public const int ID_CONST = -520655432;
    public override int Id => ID_CONST;
    public override string Description => "Vulcan starts shooting";


}