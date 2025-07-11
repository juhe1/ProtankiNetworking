using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Entry;

/// <summary>
///     Server sends options for Login
/// </summary>
public class LoginReady : AbstractPacket
{
    public const int ID_CONST = -1277343167;
    public override int Id => ID_CONST;
    public override string Description => "Server sends options for Login";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance,
        BoolCodec.Instance,
        IntCodec.Instance,
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "bgResourceID",
        "requireEmail",
        "maxPWLen",
        "minPWLen"
    };
}