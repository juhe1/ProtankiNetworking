using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Client moved passively
/// </summary>
public class TankMovementInfo : Packet
{
    [Encode(0)]
    public int ClientTime { get; set; }

    [Encode(1)]
    public short SpecificationID { get; set; }

    [Encode(2)]
    public MoveData? Movement { get; set; }

    [Encode(3)]
    public float TurretDirection { get; set; }

    public const int ID_CONST = -1683279062;
    public override int Id => ID_CONST;
    public override string Description => "Client moved passively";


}