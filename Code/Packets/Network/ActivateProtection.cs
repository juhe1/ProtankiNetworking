

namespace ProtankiNetworking.Packets.Network;

/// <summary>
///     Contains the keys required to activate packet encryption
/// </summary>
public class ActivateProtection : Packet
{
    [Encode(0)]
    public byte[]? Keys { get; set; }

    public const int ID_CONST = 2001736388;
    public override int Id => ID_CONST;
    public override string Description => "Contains the keys required to activate packet encryption";


}