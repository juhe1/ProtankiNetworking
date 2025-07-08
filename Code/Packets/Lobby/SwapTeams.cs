using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Swaps teams in a battle
/// </summary>
public class SwapTeams : AbstractPacket
{
    public static int Id { get; } = -994817471;
    public override string Description => "Swaps teams in a battle";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "battleID"
    };
}