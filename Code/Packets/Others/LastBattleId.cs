using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Others;

/// <summary>
///     Get the id of the last battle you selected
/// </summary>
public class LastBattleId : AbstractPacket
{
    public static int Id { get; } = -602527073;
    public override string Description => "Get the id of the last battle you selected";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "battleId"
    };
}