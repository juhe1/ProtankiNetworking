using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;

namespace ProtankiNetworking.Packets.Chat;

/// <summary>
///     Packet for adding a team message to battle chat (userId, message, team).
/// </summary>
public class BattleChatAddTeamMessage : AbstractPacket
{
    public const int IdStatic = -449356094;
    public override int Id => IdStatic;
    public override string Description => "Battle chat add team message (userId, message, team)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance, // userId
        StringCodec.Instance, // message
        BattleTeamCodec.Instance // team
    };

    public override string[] Attributes => new[]
    {
        "userId",
        "message",
        "team"
    };
}