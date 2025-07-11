using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for sending Isida stop out event.
/// </summary>
public class IsidaStopOut : AbstractPacket
{
    public const int ID_CONST = -1051248475;
    public override int Id => ID_CONST;
    public override string Description => "Send Isida stop out event";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance // time
    };

    public override string[] Attributes => new[]
    {
        "time"
    };
}