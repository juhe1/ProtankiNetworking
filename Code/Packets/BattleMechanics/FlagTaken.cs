using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;
using ProtankiNetworking.Codec.Custom;

namespace ProtankiNetworking.Packets.BattleMechanics;

/// <summary>
///     Packet for when a flag is taken by a tank.
/// </summary>
public class FlagTaken : AbstractPacket
{
    public static int IdStatic { get; } = -1282406496;
    public override int Id => IdStatic;
    public override string Description => "Flag taken by tank";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance, // tankId
        BattleTeamCodec.Instance // flagTeam
    };

    public override string[] Attributes => new[]
    {
        "tankId",
        "flagTeam"
    };
}