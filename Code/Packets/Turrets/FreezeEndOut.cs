

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     When we stop using Freeze
/// </summary>
public class FreezeEndOut : Packet
{
    [Encode(0)]
    public int ClientTime { get; set; }

    public const int ID_CONST = -1654947652;
    public override int Id => ID_CONST;
    public override string Description => "When we stop using Freeze";


}