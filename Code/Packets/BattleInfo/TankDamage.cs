using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Damage dealt to a tank
/// </summary>
public class TankDamage : AbstractPacket
{
    public static int Id { get; } = -1165230470;
    public override string Description => "Damage dealt to a tank";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        new VectorCodec(TankDamageCodec.Instance, false)
    };

    public override string[] Attributes => new[]
    {
        "damages"
    };
}