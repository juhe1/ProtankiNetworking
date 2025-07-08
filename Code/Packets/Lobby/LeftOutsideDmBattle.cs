using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     A player has left a DM battle, the observer being outside the battle
/// </summary>
public class LeftOutsideDmBattle : AbstractPacket
{
    public static int IdStatic { get; } = 504016996;
    public override int Id => IdStatic;
    public override string Description => "A player has left a DM battle, the observer being outside the battle";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        StringCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "battleID",
        "username"
    };
}