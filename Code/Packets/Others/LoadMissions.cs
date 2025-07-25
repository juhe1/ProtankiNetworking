

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     User requests to load their missions
/// </summary>
public class LoadMissions : Packet
{
    public const int ID_CONST = 1227293080;
    public override int Id => ID_CONST;
    public override string Description => "User requests to load their missions";


}