

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Said name is available for registration
/// </summary>
public class NameAvailable : Packet
{
    public const int ID_CONST = -706679202;
    public override int Id => ID_CONST;
    public override string Description => "Said name is available for registration";


}