using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     A tank has been killed
/// </summary>
public class KillConfirm : AbstractPacket
{
    public const int ID_CONST = -42520728;
    public override int Id => ID_CONST;
    public override string Description => "A tank has been killed";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        StringCodec.Instance,
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "target",
        "killer",
        "respDelay"
    };
}