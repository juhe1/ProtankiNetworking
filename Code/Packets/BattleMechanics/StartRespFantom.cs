using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Information about fantom status of a player
/// </summary>
public class StartRespFantom : AbstractPacket
{
    public static int IdStatic { get; } = 875259457;
    public override int Id => IdStatic;
    public override string Description => "Information about fantom status of a player";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        IntCodec.Instance,
        Vector3DCodec.Instance,
        Vector3DCodec.Instance,
        ShortCodec.Instance,
        ShortCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "username",
        "team",
        "position",
        "orientation",
        "health",
        "incarnationID"
    };
}