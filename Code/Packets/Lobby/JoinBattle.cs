

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Client requests to join the selected battle
/// </summary>
public class JoinBattle : Packet
{
    [Encode(0)]
    public int Team { get; set; }

    public const int ID_CONST = -1284211503;
    public override int Id => ID_CONST;
    public override string Description => "Client requests to join the selected battle";


}