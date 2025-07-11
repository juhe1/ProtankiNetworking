using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Swaps teams in a battle
/// </summary>
public class SwapTeams : AbstractPacket
{
    public const int IdStatic = -994817471;
    public override int Id => IdStatic;
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