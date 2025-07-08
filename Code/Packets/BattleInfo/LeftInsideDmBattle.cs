using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     A player has left a DM battle, the observer being within the battle
/// </summary>
public class LeftInsideDmBattle : AbstractPacket
{
    public static int Id { get; } = -1689876764;
    public override string Description => "A player has left a DM battle, the observer being within the battle";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "username"
    };
}