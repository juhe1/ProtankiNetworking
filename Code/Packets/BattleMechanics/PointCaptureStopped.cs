using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Custom;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for when a team stops capturing a point (team: BattleTeam).
/// </summary>
public class PointCaptureStopped : AbstractPacket
{
    public const int ID_CONST = -1701488017;
    public override int Id => ID_CONST;
    public override string Description => "Point capture stopped (team)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        BattleTeamCodec.Instance // team
    };

    public override string[] Attributes => new[]
    {
        "team"
    };
}