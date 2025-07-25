

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for updating user score property.
/// </summary>
public class UserPropertyUpdateScore : Packet
{
    [Encode(0)]
    public int Score { get; set; }

    public const int ID_CONST = 2116086491;
    public override int Id => ID_CONST;
    public override string Description => "Update user score property";


}