using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Custom;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for when a team starts capturing a point (team: BattleTeam).
/// </summary>
public class PointCaptureStarted : AbstractPacket
{
    public const int IdStatic = -1346883037;
    public override int Id => IdStatic;
    public override string Description => "Point capture started (team)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        BattleTeamCodec.Instance // team
    };

    public override string[] Attributes => new[]
    {
        "team"
    };
}