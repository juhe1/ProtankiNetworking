using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Starts a new round in the existing battle
/// </summary>
public class RoundStart : AbstractPacket
{
    public static int Id { get; } = -344514517;
    public override string Description => "Starts a new round in the existing battle";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "battleID"
    };
}