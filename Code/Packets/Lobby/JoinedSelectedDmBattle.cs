using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Sent when a player joins the currently-selected DM battle.
/// </summary>
public class JoinedSelectedDmBattle : AbstractPacket
{
    public static int Id { get; } = -911626491;
    public override string Description => "Sent when a player joins the currently-selected DM battle.";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        BattleInfoUserCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "battleID",
        "userInfo"
    };
}