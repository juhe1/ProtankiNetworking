

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     User Changed Equipment
/// </summary>
public class UserChangedEquipment : Packet
{
    [Encode(0)]
    public string? Tank { get; set; }

    public const int ID_CONST = -1767633906;
    public override int Id => ID_CONST;
    public override string Description => "User Changed Equipment";


}