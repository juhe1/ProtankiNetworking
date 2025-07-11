using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;
using ProtankiNetworking.Codec.Primitive;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Sent when a player joins the currently-selected Team battle.
/// </summary>
public class JoinedSelectedTeamBattle : AbstractPacket
{
    public static int IdStatic { get; } = 118447426;
    public override int Id => IdStatic;
    public override string Description => "Sent when a player joins the currently-selected Team battle.";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance,
        BattleInfoUserCodec.Instance,
        IntCodec.Instance
    };

    public override string[] Attributes => new[]
    {
        "battleID",
        "userInfo",
        "team"
    };
}