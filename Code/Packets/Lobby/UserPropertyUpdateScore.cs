using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for updating user score property.
/// </summary>
public class UserPropertyUpdateScore : AbstractPacket
{
    public static int IdStatic { get; } = 2116086491;
    public override int Id => IdStatic;
    public override string Description => "Update user score property";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance // score
    };

    public override string[] Attributes => new[]
    {
        "score"
    };
}