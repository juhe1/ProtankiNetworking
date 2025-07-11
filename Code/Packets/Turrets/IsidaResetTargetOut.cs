using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for sending Isida reset target out event.
/// </summary>
public class IsidaResetTargetOut : AbstractPacket
{
    public const int ID_CONST = -248693565;
    public override int Id => ID_CONST;
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