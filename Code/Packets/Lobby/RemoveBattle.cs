using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Removes a battle from the lobby
/// </summary>
public class RemoveBattle : AbstractPacket
{
    public static int Id { get; } = -1848001147;
    public override string Description => "Removes a battle from the lobby";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "battleID"
    };
}