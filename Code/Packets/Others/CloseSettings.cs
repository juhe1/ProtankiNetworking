

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Close settings modal
/// </summary>
public class CloseSettings : Packet
{
    [Encode(0)]
    public bool Close_state { get; set; }

    public const int ID_CONST = -731115522;
    public override int Id => ID_CONST;
    public override string Description => "Close settings modal";


}