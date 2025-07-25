

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Check if a name is up for registration
/// </summary>
public class CheckNameAvailability : Packet
{
    [Encode(0)]
    public string? Username { get; set; }

    public const int ID_CONST = 1083705823;
    public override int Id => ID_CONST;
    public override string Description => "Check if a name is up for registration";


}