using ProtankiNetworking.Codec;
using ProtankiNetworking.Codec.Complex;

namespace ProtankiNetworking.Packets.Lobby;

/// <summary>
///     Packet to show a warning that the player is trying to join with wrong equipment into DM battle.
/// </summary>
public class EquipmentNotMatchConstraints : AbstractPacket
{
    public static int Id { get; } = 1229594925;

    public override string Description =>
        "Warns that the player is trying to join with wrong equipment into DM battle.";

    public override BaseCodec[] CodecObjects => new BaseCodec[]
    {
        StringCodec.Instance // battleDMInfoObjectId
    };

    public override string[] Attributes => new[]
    {
        "battleDMInfoObjectId"
    };
}