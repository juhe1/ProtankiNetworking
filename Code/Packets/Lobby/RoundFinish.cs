using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     The existing battle round has finished
/// </summary>
public class RoundFinish : AbstractPacket
{
    public static int Id { get; } = 1534651002;
    public override string Description => "The existing battle round has finished";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "battleID"
    };
}