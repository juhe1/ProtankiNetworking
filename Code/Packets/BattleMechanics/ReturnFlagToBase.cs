using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for returning a flag to base, specifying the team and tank.
/// </summary>
public class ReturnFlagToBase : AbstractPacket
{
    public const int ID_CONST = -1026428589;
    public override int Id => ID_CONST;
    public override string Description => "Return flag to base (team and tank)";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        BattleTeamCodec.Instance, // flagTeam
        StringCodec.Instance // tank
    };

    public override string[] Attributes => new[]
    {
        "flagTeam",
        "tank"
    };
}