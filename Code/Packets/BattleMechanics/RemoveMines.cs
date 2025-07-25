

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for removing mines by owner (ownerId).
/// </summary>
public class RemoveMines : Packet
{
    [Encode(0)]
    public string? OwnerId { get; set; }

    public const int ID_CONST = -1200619383;
    public override int Id => ID_CONST;
    public override string Description => "Remove mines (ownerId)";


}