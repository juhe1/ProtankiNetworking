

namespace ProtankiNetworking.Packets.Garage;

/// <summary>
///     Mount an item in garage
/// </summary>
public class MountItem : Packet
{
    [Encode(0)]
    public string? Item_id { get; set; }

    public const int ID_CONST = -1505530736;
    public override int Id => ID_CONST;
    public override string Description => "Mount an item in garage";


}