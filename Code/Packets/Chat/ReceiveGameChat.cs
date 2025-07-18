using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Chat;

/// <summary>
///     Receives a message from the game chat
/// </summary>
public class ReceiveGameChat : AbstractPacket
{
    public static int IdStatic { get; } = 1259981343;
    public override int Id => IdStatic;
    public override string Description => "Receives a message from the game chat";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        StringCodec.Instance,
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "username",
        "message",
        "team"
    };
}