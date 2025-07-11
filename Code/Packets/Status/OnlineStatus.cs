using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Status;

/// <summary>
///     Updates Player's Online Status
/// </summary>
public class OnlineStatus : AbstractPacket
{
    public const int IdStatic = 2041598093;
    public override int Id => IdStatic;
    public override string Description => "Updates Player's Online Status";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        BoolCodec.Instance,
        IntCodec.Instance,
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "online",
        "serverID",
        "username"
    };
}