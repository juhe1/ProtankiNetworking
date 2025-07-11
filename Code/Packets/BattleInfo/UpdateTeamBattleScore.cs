using ProtankiNetworking.Codec;

namespace ProtankiNetworking.Packets.BattleInfo;

/// <summary>
///     Update the score of a team within battle
/// </summary>
public class UpdateTeamBattleScore : AbstractPacket
{
    public const int ID_CONST = 561771020;
    public override int Id => ID_CONST;
    public override string Description => "Update the score of a team within battle";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
    };

    public override string[] Attributes => new string[]
    {
    };
}