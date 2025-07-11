using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for updating typing antiflood parameters.
/// </summary>
public class UpdateTypingAntifloodParams : AbstractPacket
{
    public const int IdStatic = 744948472;
    public override int Id => IdStatic;
    public override string Description => "Update typing antiflood parameters";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance, // symbolCost
        IntCodec.Instance // messageCost
    };

    public override string[] Attributes => new[]
    {
        "symbolCost",
        "messageCost"
    };
}