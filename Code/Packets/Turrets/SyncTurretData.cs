using System.Text.Json.Nodes;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Syncs turret data to the client
/// </summary>
public class SyncTurretData : Packet
{
    [Encode(0)]
    public JsonNode? Json { get; set; }

    public const int ID_CONST = -2124388778;
    public override int Id => ID_CONST;
    public override string Description => "Syncs turret data to the client";


}