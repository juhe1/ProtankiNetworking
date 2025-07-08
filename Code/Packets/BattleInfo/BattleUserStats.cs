using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Battle User Stats
/// </summary>
public class BattleUserStats : AbstractPacket
{
    public static int IdStatic { get; } = 1061006142;
    public override int Id => IdStatic;
    public override string Description => "Battle User Stats";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        new VectorCodec(BattleUserStatsCodec.Instance, false)
    };

    public override string[] Attributes => new[]
    {
        "usersStat"
    };
}