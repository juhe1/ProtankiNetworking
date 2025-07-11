using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Chat;

/// <summary>
///     Received a system message in the game chat
/// </summary>
public class ReceiveGameSystemChat : AbstractPacket
{
    public const int IdStatic = 606668848;
    public override int Id => IdStatic;
    public override string Description => "Received a system message in the game chat";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "message"
    };
}