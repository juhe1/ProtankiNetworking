

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Load settings
/// </summary>
public class LoadSettings : Packet
{
    public const int ID_CONST = 850220815;
    public override int Id => ID_CONST;
    public override string Description => "Load settings";


}