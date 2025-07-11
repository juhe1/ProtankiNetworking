using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Client requests to join the selected battle
/// </summary>
public class JoinBattle : AbstractPacket
{
    public const int ID_CONST = -1284211503;
    public override int Id => ID_CONST;
    public override string Description => "Client requests to join the selected battle";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "team"
    };
}