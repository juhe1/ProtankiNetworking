

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Login failed
/// </summary>
public class LoginFailed : Packet
{
    public const int ID_CONST = 103812952;
    public override int Id => ID_CONST;
    public override string Description => "Login failed";


}