using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for sending Isida reset target out event.
/// </summary>
public class IsidaResetTargetOut : AbstractPacket
{
    public static int IdStatic { get; } = -248693565;
    public override int Id => IdStatic;
    public override string Description => "Send Isida reset target out event";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance // time
    };

    public override string[] Attributes => new[]
    {
        "time"
    };
}