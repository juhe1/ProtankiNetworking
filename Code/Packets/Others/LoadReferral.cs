

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Load garage
/// </summary>
public class LoadReferral : Packet
{
    public const int ID_CONST = -169921234;
    public override int Id => ID_CONST;
    public override string Description => "Load garage";


}