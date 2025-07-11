using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet for updating user score property.
/// </summary>
public class UserPropertyUpdateScore : AbstractPacket
{
    public const int ID_CONST = 2116086491;
    public override int Id => ID_CONST;
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