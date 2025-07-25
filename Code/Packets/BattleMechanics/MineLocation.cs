using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Sent when a mine is placed or removed.
/// </summary>
public class MineLocation : AbstractPacket
{
    public const int ID_CONST = 272183855;
    public override int Id => ID_CONST;
    public override string Description => "Sent when a mine is placed or removed.";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        FloatCodec.Instance,
        FloatCodec.Instance,
        FloatCodec.Instance,
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "mineId",
        "x",
        "y",
        "z",
        "userId"
    };
}