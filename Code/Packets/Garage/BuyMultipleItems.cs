

namespace ProtankiNetworking.Packets.Garage;

/// <summary>
///     Buy multiple items from garage, like supplies, xp boosts
/// </summary>
public class BuyMultipleItems : Packet
{
    [Encode(0)]
    public string? Item_id { get; set; }

    [Encode(1)]
    public int Count { get; set; }

    [Encode(2)]
    public int Base_cost { get; set; }

    public const int ID_CONST = -1961983005;
    public override int Id => ID_CONST;
    public override string Description => "Buy multiple items from garage, like supplies, xp boosts";


}