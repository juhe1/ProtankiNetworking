using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Chat;

/// <summary>
///     Sends a message to the game chat
/// </summary>
public class SendGameChat : AbstractPacket
{
    public const int ID_CONST = 945463181;
    public override int Id => ID_CONST;
    public override string Description => "Sends a message to the game chat";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        BoolCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "message",
        "teamOnly"
    };
}