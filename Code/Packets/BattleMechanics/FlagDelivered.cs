using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for flag delivery event, indicating the winning team and the deliverer tank ID.
/// </summary>
public class FlagDelivered : AbstractPacket
{
    public const int ID_CONST = -1870108387;
    public override int Id => ID_CONST;
    public override string Description => "Flag delivered event (winning team and deliverer tank ID)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        BattleTeamCodec.Instance, // winnerTeam
        StringCodec.Instance // delivererTankId
    };

    public override string[] Attributes => new[]
    {
        "winnerTeam",
        "delivererTankId"
    };
}