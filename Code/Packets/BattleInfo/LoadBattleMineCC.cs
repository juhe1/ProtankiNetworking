using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Packet for loading battle mine configuration (BattleMineCC).
/// </summary>
public class LoadBattleMineCC : AbstractPacket
{
    public const int ID_CONST = -226978906;
    public override int Id => ID_CONST;
    public override string Description => "Load battle mine configuration (BattleMineCC)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance, // activateSound (ResourceGetterCodec)
        IntCodec.Instance, // activateTimeMsec
        new VectorCodec(BattleMineCodec.Instance, false), // battleMines (Vector<BattleMine>)
        IntCodec.Instance, // blueMineTexture (ResourceGetterCodec)
        IntCodec.Instance, // deactivateSound (ResourceGetterCodec)
        IntCodec.Instance, // enemyMineTexture (ResourceGetterCodec)
        IntCodec.Instance, // explosionMarkTexture (ResourceGetterCodec)
        IntCodec.Instance, // explosionSound (ResourceGetterCodec)
        FloatCodec.Instance, // farVisibilityRadius
        IntCodec.Instance, // friendlyMineTexture (ResourceGetterCodec)
        IntCodec.Instance, // idleExplosionTexture (ResourceGetterCodec)
        FloatCodec.Instance, // impactForce
        IntCodec.Instance, // mainExplosionTexture (ResourceGetterCodec)
        FloatCodec.Instance, // minDistanceFromBase
        IntCodec.Instance, // model3ds (ResourceGetterCodec)
        FloatCodec.Instance, // nearVisibilityRadius
        FloatCodec.Instance, // radius
        IntCodec.Instance // redMineTexture (ResourceGetterCodec)
    };

    public override string[] Attributes => new[]
    {
        "activateSound",
        "activateTimeMsec",
        "battleMines",
        "blueMineTexture",
        "deactivateSound",
        "enemyMineTexture",
        "explosionMarkTexture",
        "explosionSound",
        "farVisibilityRadius",
        "friendlyMineTexture",
        "idleExplosionTexture",
        "impactForce",
        "mainExplosionTexture",
        "minDistanceFromBase",
        "model3ds",
        "nearVisibilityRadius",
        "radius",
        "redMineTexture"
    };
}