

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Loads the player's friend lists
/// </summary>
public class LoadFriendsList : Packet
{
    public const int ID_CONST = 1422563374;
    public override int Id => ID_CONST;
    public override string Description => "Loads the player's friend lists";


}