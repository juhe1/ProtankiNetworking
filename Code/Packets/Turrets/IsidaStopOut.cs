using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Turrets;

/// <summary>
///     Packet for sending Isida stop out event.
/// </summary>
public class IsidaStopOut : AbstractPacket
{
    public const int IdStatic = -1051248475;
    public override int Id => IdStatic;
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