using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Announces that a gold box will drop soon
/// </summary>
public class GoldBoxDropText : AbstractPacket
{
    public const int ID_CONST = -666893269;
    public override int Id => ID_CONST;
    public override string Description => "Announces that a gold box will drop soon";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "text",
        "soundID"
    };
}