using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Load Bonus Box Resources
/// </summary>
public class LoadBonusBoxResources : AbstractPacket
{
    public static int IdStatic { get; } = 228171466;
    public override int Id => IdStatic;
    public override string Description => "Load Bonus Box Resources";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "json"
    };
}