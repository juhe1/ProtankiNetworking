using ProtankiNetworking.EncodableData;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Packet for loading battle mine configuration (BattleMineCC).
/// </summary>
public class LoadBattleMineCC : Packet
{
    [Encode(0)]
    public int ActivateSound { get; set; }

    [Encode(1)]
    public int ActivateTimeMsec { get; set; }

    [Encode(2)]
    public BattleMine?[]? BattleMines { get; set; }

    [Encode(3)]
    public int BlueMineTexture { get; set; }

    [Encode(4)]
    public int DeactivateSound { get; set; }

    [Encode(5)]
    public int EnemyMineTexture { get; set; }

    [Encode(6)]
    public int ExplosionMarkTexture { get; set; }

    [Encode(7)]
    public int ExplosionSound { get; set; }

    [Encode(8)]
    public float FarVisibilityRadius { get; set; }

    [Encode(9)]
    public int FriendlyMineTexture { get; set; }

    [Encode(10)]
    public int IdleExplosionTexture { get; set; }

    [Encode(11)]
    public float ImpactForce { get; set; }

    [Encode(12)]
    public int MainExplosionTexture { get; set; }

    [Encode(13)]
    public float MinDistanceFromBase { get; set; }

    [Encode(14)]
    public int Model3ds { get; set; }

    [Encode(15)]
    public float NearVisibilityRadius { get; set; }

    [Encode(16)]
    public float Radius { get; set; }

    [Encode(17)]
    public int RedMineTexture { get; set; }

    public const int ID_CONST = -226978906;
    public override int Id => ID_CONST;
    public override string Description => "Load battle mine configuration (BattleMineCC)";


}