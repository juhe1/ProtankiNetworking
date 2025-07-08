using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Client requests to join the selected battle
/// </summary>
public class JoinBattle : AbstractPacket
{
    public static int IdStatic { get; } = -1284211503;
    public override int Id => IdStatic;
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