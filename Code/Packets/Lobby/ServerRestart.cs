using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Indicates time (in seconds) until server restart
/// </summary>
public class ServerRestart : AbstractPacket
{
    public const int ID_CONST = -1712113407;
    public override int Id => ID_CONST;
    public override string Description => "Indicates time (in seconds) until server restart";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "time"
    };
}