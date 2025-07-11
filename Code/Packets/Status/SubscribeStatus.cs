using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Status;

/// <summary>
///     Subscribe to status updates of a player.
/// </summary>
public class SubscribeStatus : AbstractPacket
{
    public const int IdStatic = 1774907609;
    public override int Id => IdStatic;
    public override string Description => "Subscribe to status updates of a player.";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "username"
    };
}