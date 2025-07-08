using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Load Current Supply Effect
/// </summary>
public class LoadSupplyEffect : AbstractPacket
{
    public static int Id { get; } = 417965410;
    public override string Description => "Load Current Supply Effect";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "json"
    };
}