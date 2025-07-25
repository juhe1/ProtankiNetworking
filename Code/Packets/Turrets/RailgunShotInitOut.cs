

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Sends server details about a railgun shot that has just started to release
/// </summary>
public class RailgunShotInitOut : Packet
{
    [Encode(0)]
    public int ClientTime { get; set; }

    public const int ID_CONST = -1759063234;

    public override string Description =>
        "Sends server details about a railgun shot that has just started to release";


}