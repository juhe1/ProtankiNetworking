

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for sending Twins fire dummy event.
/// </summary>
public class TwinsFireDummyIn : Packet
{
    [Encode(0)]
    public string? Shooter { get; set; }

    [Encode(1)]
    public byte FireType { get; set; }

    public const int ID_CONST = -328554480;
    public override int Id => ID_CONST;
    public override string Description => "Send Twins fire dummy event";


}