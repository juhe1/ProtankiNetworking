using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Sends your movement data to the server
/// </summary>
public class Move : Packet
{
    [Encode(0)]
    public int ClientTime { get; set; }

    [Encode(1)]
    public short SpecificationID { get; set; }

    [Encode(2)]
    public MoveData? Movement { get; set; }

    public const int ID_CONST = 329279865;
    public override int Id => ID_CONST;
    public override string Description => "Sends your movement data to the server";


}