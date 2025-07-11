using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Status;

/// <summary>
///     Subscribe to status updates of a player.
/// </summary>
public class SubscribeStatus : AbstractPacket
{
    public const int ID_CONST = 1774907609;
    public override int Id => ID_CONST;
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