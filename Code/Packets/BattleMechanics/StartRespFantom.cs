using ProtankiNetworking.Utils;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Information about fantom status of a player
/// </summary>
public class StartRespFantom : Packet
{
    [Encode(0)]
    public string? Username { get; set; }

    [Encode(1)]
    public int Team { get; set; }

    [Encode(2)]
    public Vector3D? Position { get; set; }

    [Encode(3)]
    public Vector3D? Orientation { get; set; }

    [Encode(4)]
    public short Health { get; set; }

    [Encode(5)]
    public short IncarnationID { get; set; }

    public const int ID_CONST = 875259457;
    public override int Id => ID_CONST;
    public override string Description => "Information about fantom status of a player";


}