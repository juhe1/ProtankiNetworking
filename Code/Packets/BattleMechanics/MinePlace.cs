using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Sent when a mine is placed.
/// </summary>
public class MinePlace : AbstractPacket
{
    public static int IdStatic { get; } = -624217047;
    public override int Id => IdStatic;
    public override string Description => "Sent when a mine is placed.";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "mineId"
    };
}