using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Loads limited info about a newly created battle
/// </summary>
public class BattleCreated : AbstractPacket
{
    public static int IdStatic { get; } = 802300608;
    public override int Id => IdStatic;
    public override string Description => "Loads limited info about a newly created battle";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        JsonCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "json"
    };
}